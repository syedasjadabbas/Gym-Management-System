using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class Member_form : UserControl
    {
        ControlCollection control1;
        string Querry;
        string querry2;
        bool flag = true;
        public Member_form(ControlCollection control)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            control1 = control;
            textBox4.MaxLength = 11;
            dateTimePicker1.Value = DateTime.Now.Date;
            dateTimePicker1.MaxDate = DateTime.Now;


            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                try
                {
                    string Querry = "Select MembershipName from membership";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(Querry, conn);
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        comboBox1.Items.Add(sqlDataReader["MembershipName"].ToString());
                    }
                    sqlDataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            comboBox2.Items.Add("Card Payment");
            comboBox2.Items.Add("Cash");
            comboBox2.Items.Add("Online Transaction");
        }

        private void Member_form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.textBox1.Text;
            string age = this.textBox2.Text;
            string Gender;
            int bit;
            int Fees = 0;
            int total = 0;
            int reg = 0;
            int dis = 0;
            if (textBox2.Text.All(Char.IsDigit))
            {
                label35.Visible = false;
            }
            else
            {
                label35.Visible = true;
            }
            if (textBox4.Text.All(Char.IsDigit)) {
                label36.Visible = false;
            }
            else {label36.Visible = true; }
            if (textBox6.Text != "")
            {
                dis = Int32.Parse(textBox6.Text);
            }
            if (radioButton1.Checked)
            {
                Gender = "M";
            }
            else
            {
                Gender = "F";
            }
            if (checkBox1.Checked)
            {
                bit = 1;
            }
            else { bit = 0; }
            string Phone_number = this.textBox4.Text;
            DateTime date;
            DateTime day;
            string admission_date;
            if (dateTimePicker1.Value.Date < new DateTime(DateTime.Now.Year, (DateTime.Now.Month - 1), DateTime.Now.Day))
            {
                date = dateTimePicker1.Value;
                day = new DateTime(DateTime.Now.Year, DateTime.Now.Month, date.Day);
                if (bit == 0 && day > DateTime.Now)
                {
                    day = new DateTime(DateTime.Now.Year, DateTime.Now.Month - 2, date.Day);
                    bit = 2;
                }
                else if (bit == 1 && day < DateTime.Now)
                {

                }
                else if (bit == 1 && day > DateTime.Now)
                {
                    day = new DateTime(DateTime.Now.Year, DateTime.Now.Month - 1, date.Day);
                }
                else
                {
                    day = new DateTime(DateTime.Now.Year, DateTime.Now.Month - 1, date.Day);
                    bit = 2;
                }
            }
            else
            {
                date = DateTime.Now;
                day = DateTime.Now;
            }
            admission_date = date.ToString("MM/dd/yyyy");

            using (SqlConnection connection = new(Properties.Settings.Default.ConnectionString))
            {
                try
                {
                    connection.Open();

                    querry2 = $"select fees,Membership_id from membership\r\nwhere MembershipName = '{comboBox1.Text}'";
                    SqlCommand cmd = new SqlCommand(querry2, connection);
                    string id = "";
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        id = reader["membership_id"].ToString();
                        Fees = (int)reader["fees"];
                    }
                    if (dateTimePicker1.Value.Date < new DateTime(DateTime.Now.Year, (DateTime.Now.Month - 1), DateTime.Now.Day))
                    {
                        if (bit != 0)
                        {
                            total = Fees - dis;
                        }
                        else
                        {
                            total = Fees;
                        }
                    }
                    else
                    {
                        reg = Helper.getCounter("Registration");
                        if (bit != 0)
                        {
                            total = (reg + Fees) - dis;
                        }
                        else
                        {
                            total = Fees + reg;
                        }
                    }
                    int no = Helper.getCounter("members");
                    if (bit == 0)
                    {
                        if (!(name == "" || age == "" || Phone_number == "" || textBox3.Text == ""))
                        {
                            label33.Visible = false;
                            flag = true;
                            querry2 = $"insert into payment values('PA0{Helper.getCounter("payment")}','MB0{no}','{id}',Null,null,null,null,0,0)";
                            Querry = $"INSERT INTO members values('MB0{no}','{name}',{age},'{Gender}','{Phone_number}','{admission_date}','{textBox3.Text}','{admission_date}',{bit})";
                        }
                        else
                        {

                            label33.Visible = true;
                            flag = false;
                        }
                    }
                    else
                    {
                        if (bit == 2) { bit = 0; }
                        if (!(name == "" || age == "" || Phone_number == "" || textBox3.Text == "" || comboBox2.Text == "" || textBox5.Text == ""))
                        {
                            label34.Visible = false;
                            flag = true;
                            Querry = $"INSERT INTO members values('MB0{no}','{name}',{age},'{Gender}','{Phone_number}','{admission_date}','{textBox3.Text}','{day.AddMonths(1).ToString("MM/dd/yyyy")}',{bit})";
                            querry2 = $"insert into payment values('PA0{Helper.getCounter("payment")}','MB0{no}','{id}','{day.ToString("MM/dd/yyyy HH:mm")}','{comboBox2.Text}','{textBox5.Text}',{dis.ToString()},{total},{Fees})";
                        }
                        else
                        {
                            label34.Visible = true;
                            flag = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                label28.Text = name;
                label30.Text = Phone_number;
                label20.Text = admission_date;
                label29.Text = comboBox1.Text;
                label26.Text = Fees.ToString();
                label23.Text = reg.ToString();
                label21.Text = total.ToString();
                if (bit != 0)
                {
                    label31.Text = comboBox2.Text;
                    label27.Text = textBox6.Text;
                }
                panel1.Visible = true;
                button1.Text = "Update";


            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag && !label35.Visible && !label36.Visible)
            {
                Helper.QuerryExecute(Querry);
                Helper.QuerryExecute(querry2);

                MessageBox.Show("Member added Successfully");
                Properties.Settings.Default.Save();
                control1.Clear();
                Members members = new Members();
                control1.Add(members);
                members.panel.Controls.Add(new Member_form(control1));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            control1.Clear();
            Members members = new Members();
            control1.Add(members);
            members.panel.Controls.Add(new Member_form(control1));
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
