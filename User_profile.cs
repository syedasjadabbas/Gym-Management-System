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
    public partial class User_profile : UserControl
    {
        string roll;
        ControlCollection control1;
        public User_profile(ControlCollection control, string rollno)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            roll = rollno;
            control1 = control;

            using (SqlConnection connection = new(Properties.Settings.Default.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string Querry = $"Select Measurement_id,Datename(MONTH, Measurement_date) as Month_name,Measurement_Date,Neck,weight_,Shoulders,Biceps_R,Biceps_L,Bust,Waist,LowerAbdomen,Hips,Thighs_R,Thighs_l,Calves_L,Calves_R  from measurements where memberid = '{rollno}'";
                    SqlDataAdapter adapter = new SqlDataAdapter(Querry, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    panel9.Controls.Add(dataGridView1);

                    dataGridView1.DataSource = dt;
                    Querry = $"select Member_id,name,age,Gender,PhoneNumber,Date_of_payment,Admission_Date,Address,MembershipName,Payment_date from membership join (select m.Member_id,name,age,Gender,PhoneNumber,Admission_Date,date_of_payment,Address,Payment_date,Membership_id from members join (select Top 1 member_id,Membership_id,Payment_date from payment where Member_id = '{rollno}' order by Payment_date Desc) as M on M.member_id=members.Member_id)as p on p.Membership_id = membership.Membership_id";
                    SqlCommand sqlCommand = new SqlCommand(Querry, connection);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        label2.Text = reader["name"].ToString();
                        label18.Text = reader["member_ID"].ToString();
                        label3.Text = reader["age"].ToString();
                        label5.Text = reader["Gender"].ToString();
                        label7.Text = reader["PhoneNumber"].ToString();
                        label11.Text = reader["MembershipName"].ToString();
                        label12.Text = Convert.ToDateTime(reader["Admission_date"]).ToString("MM/dd/yyyy");
                        label14.Text = Convert.ToDateTime(reader["date_of_payment"]).ToString("MM/dd/yyyy");
                        label20.Text = reader["Address"].ToString();
                        if (!(reader["payment_date"] is DBNull))
                        {
                            label21.Text = Convert.ToDateTime(reader["payment_date"]).ToString("MM/dd/yyyy");
                        }

                    }
                    reader.Close();
                    Querry = "Select MembershipName from membership";
                    SqlCommand cmd = new SqlCommand(Querry, connection);
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

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            button5.Visible = false;
            panel9.Controls.Clear();
            panel9.Controls.Add(new Measurements(roll, this.Controls, control1));
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = label2.Text;
            textBox2.Text = label3.Text;
            textBox3.Text = label5.Text;
            textBox4.Text = label7.Text;
            textBox5.Text = label20.Text;
            comboBox1.Text = label11.Text;
            dateTimePicker1.Value = DateTime.Now;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            comboBox1.Visible = true;
            button2.Visible = true;
            dateTimePicker1.Visible = true;
            button4.Visible = true;
            button1.Visible = false;


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string querry = $"Update members set name = '{textBox1.Text}', age = {textBox2.Text}, Gender = '{textBox3.Text}',Date_of_Payment = '{dateTimePicker1.Value.ToString("MM/dd/yyyy")}',PhoneNumber = '{textBox4.Text}',Address = '{textBox5.Text}' where member_id = '{roll}' update payment set Membership_id = (select Membership_id from membership where MembershipName = '{comboBox1.Text}') where member_id = '{roll}'";
           
            Helper.QuerryExecute(querry);
            control1.Clear();
            Members members = new Members();
            control1.Add(members);
            members.panel.Controls.Add(new User_profile(control1, roll));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            comboBox1.Visible = false;
            button2.Visible = false;
            dateTimePicker1.Visible = false;
            button4.Visible = false;
            button1.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells["Column16"].Value.ToString();
            string querry = $"Delete from measurements where measurement_id = '{id}'";
            Helper.QuerryExecute(querry);
            this.Controls.Clear();
            this.Controls.Add(new User_profile(control1, roll));
        }

        private void User_profile_Load(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
