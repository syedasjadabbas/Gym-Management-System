using iTextSharp.text;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GymManagement
{
    public partial class Dashboard : UserControl
    {
        string trainer = "";
        string cls = "";
        public Dashboard()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            Helper.SetRoundedButton(button1, 40);
            Helper.SetRoundedButton(button2, 40);
            string Querry = $"Update Gym_info set connectionString = '{Properties.Settings.Default.ConnectionString}'";
            Helper.QuerryExecute(Querry);
            Querry = $"update members set payment_status = 0 where date_of_payment < '{DateTime.Now.ToString("yyyy/MM/dd")}'";
            Helper.QuerryExecute(Querry);
            Querry = $"update members set payment_status = 1 where date_of_payment > '{DateTime.Now.ToString("yyyy/MM/dd")}'";
            Helper.QuerryExecute(Querry);
            Querry = "select COUNT(name) from members";
            int no = (int)Helper.ScalarExecute(Querry);
            label1.Text = no.ToString();
            Querry = $"select COUNT(Schedule_id) from classes where class_date = '{DateTime.Now.ToString("MM/dd/yyyy")}'";
            label13.Text = ((int)Helper.ScalarExecute(Querry)).ToString();
            Querry = "select count(member_id) from members where Payment_status = 0";
            no = (int)Helper.ScalarExecute(Querry);
            label5.Text = no.ToString();
            no = Helper.getCounter("Registration");
            label7.Text = no.ToString("#,##0");

            using (SqlConnection connection = new(Properties.Settings.Default.ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand sqlCommand;
                    Querry = "SELECT p.payment_id,m.member_id,m.name,p.payment_date, mem.membershipname,m.PhoneNumber,m.date_of_payment FROM members m INNER JOIN     payment p ON m.member_id = p.member_id INNER JOIN  membership mem ON p.membership_id = mem.membership_id WHERE  m.payment_status = 0   AND p.payment_date = (  SELECT MAX(payment_date) FROM payment WHERE payment.member_id = m.member_id ) OR m.payment_status = 0 AND p.payment_date is null ORDER BY  p.payment_date DESC;\r\n";
                    SqlDataAdapter adapter = new SqlDataAdapter(Querry, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dt.Columns.Add("Fees", typeof(int));
                    foreach (DataRow dr in dt.Rows)
                    {
                        Querry = $"select fees from membership where membershipname = '{dr["membershipname"].ToString()}'";
                        sqlCommand = new SqlCommand(Querry, connection);
                        int fees = (int)sqlCommand.ExecuteScalar();
                        if (dr["Payment_date"] is DBNull)
                        {
                            dr["Fees"] = fees + Helper.getCounter("Registration");
                        }
                        else
                        {
                            dr["Fees"] = fees;
                        }
                    }

                    dataGridView1.DataSource = dt;

                    Querry = $"Select Name from class_name";
                    sqlCommand = new SqlCommand(Querry, connection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        comboBox1.Items.Add(sqlDataReader["Name"].ToString());
                    }
                    sqlDataReader.Close();
                    Querry = $"Select FirstName from trainers";
                    sqlCommand = new SqlCommand(Querry, connection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        comboBox2.Items.Add(sqlDataReader["FirstName"].ToString());
                    }
                    sqlDataReader.Close();

                    Querry = $"select Schedule_id,Name,FirstName,Class_date,StartingTime,EndingTime from classes join class_name on classes.Class_id = class_name.Class_id join trainers on trainers.Trainer_id = classes.Trainer_id where Class_date = '{DateTime.Now.ToString("MM/dd/yyyy")}'\r\n";
                    adapter = new SqlDataAdapter(Querry, connection);
                    DataTable data = new DataTable();
                    adapter.Fill(data);

                    dataGridView2.DataSource = data;
                    if (First_page.is_going)
                    {
                        panel2.Visible = true;
                        comboBox2.Text = Properties.Settings.Default.trainer;
                        button4.Text = "End Class";
                        button3.Text = "Cancel";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            Helper.QuerryExecute(Properties.Settings.Default.BackupString);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();


            if (Helper.flag == 1)
            {
                string id = dataGridView1.CurrentRow.Cells["Column1"].Value.ToString();
                string membership = dataGridView1.CurrentRow.Cells["Column4"].Value.ToString();
                DateTime date = (DateTime)dataGridView1.CurrentRow.Cells["Column7"].Value;
                int fees = 0;
                string querry2 = $"select Membership_id from membership\r\nwhere MembershipName = '{membership}'";
                membership = (string)Helper.ScalarExecute(querry2);
                querry2 = $"select fees from membership where membership_id = '{membership}'";
                fees = (int)Helper.ScalarExecute(querry2);
                string querry;
                if (!(dataGridView1.CurrentRow.Cells["Column3"].Value is DBNull))
                {
                    int Total = fees - Form1.fees;
                    int no = Helper.getCounter("payment");
                    querry = $"Insert into payment values('PA0{no}','{id}','{membership}','{DateTime.Now.ToString("MM/dd/yyyy HH:mm")}','{Form1.medium}','{Form1.notes}',{Form1.fees},{Total},{fees}) update members Set date_of_payment = '{date.AddMonths(1).ToString("MM/dd/yyyy")}' WHERE Member_id = '{id}'";
                }
                else
                {
                    int Total = (fees + Helper.getCounter("Registration")) - Form1.fees;
                    querry = $"update payment set payment_date = '{DateTime.Now.ToString("MM/dd/yyyy HH:mm")}',payment_medium = '{Form1.medium}',addnotes = '{Form1.notes}',discount = {Form1.fees},fees_paid = {fees} ,Total_amount = {Total} where payment_id = '{dataGridView1.CurrentRow.Cells["Column8"].Value.ToString()}' update members set date_of_payment = '{date.AddMonths(1).ToString("MM/dd/yyyy")}' where member_id = '{id}'";
                }
                Helper.QuerryExecute(querry);
                Properties.Settings.Default.Save();
                this.Controls.Clear();
                this.Controls.Add(new Dashboard());


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string id = row.Cells["Column1"].Value.ToString();
                string Querry = $"Delete from payment where Member_id = '{id}'\r\n\tDelete from members where Member_id='{id}'";
                Helper.QuerryExecute(Querry);
                this.Controls.Clear();
                this.Controls.Add(new Dashboard());
            }

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "Start New Class")
            {
                First_page.time = DateTime.Now;

                panel2.Visible = true;
                comboBox2.Text = Properties.Settings.Default.trainer;
                button4.Text = "End Class";
                button3.Text = "Cancel";
                First_page.is_going = true;
            }
            else if (button4.Text == "End Class")
            {
                if (!(comboBox2.Text == "" || comboBox1.Text == ""))
                {
                    string querry = $"Select Class_id from class_name where name = '{comboBox1.Text}'";
                    cls = Helper.ScalarExecute(querry).ToString();
                    querry = $"Select trainer_id from trainers where firstname = '{comboBox2.Text}'";
                    trainer = Helper.ScalarExecute(querry).ToString();
                    querry = $"Insert into classes values ('SH0{Helper.getCounter("Schedule")}','{First_page.time.ToString("HH:mm:ss")}','{DateTime.Now.ToString("HH:mm:ss")}','{trainer}','{cls}','{DateTime.Now.ToString("MM/dd/yyyy")}')";
                    Helper.QuerryExecute(querry);
                    Properties.Settings.Default.Save();
                    First_page.is_going = false;
                    this.Controls.Clear();
                    this.Controls.Add(new Dashboard());
                }
                else
                {
                    label15.Visible = true;
                }
            }
            else if (button4.Text == "Delete")
            {
                string id = dataGridView2.CurrentRow.Cells["Column9"].Value.ToString();
                string querry = $"Delete from classes where schedule_id = '{id}'";
                Helper.QuerryExecute(querry);
                this.Controls.Clear();
                this.Controls.Add(new Dashboard());
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            using (SqlConnection connection = new(Properties.Settings.Default.ConnectionString))
            {
                string Querry = $"select Schedule_id,Name,FirstName,Class_date,StartingTime,EndingTime from classes join class_name on classes.Class_id = class_name.Class_id join trainers on trainers.Trainer_id = classes.Trainer_id where Class_date = '{monthCalendar1.SelectionStart.ToString("MM/dd/yyyy")}'\r\n";
                SqlDataAdapter adapter = new SqlDataAdapter(Querry, connection);
                DataTable data = new DataTable();
                adapter.Fill(data);

                dataGridView2.DataSource = data;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Show History")
            {
                monthCalendar1.Visible = true;
                label12.Visible = true;
                label9.Visible = false;
                button3.Text = "Back";
                button4.Text = "Delete";
            }
            else
            {
                First_page.is_going = false;
                this.Controls.Clear();
                this.Controls.Add(new Dashboard());
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Add_cls add_Cls = new Add_cls();
            add_Cls.ShowDialog();
            this.Controls.Clear();
            this.Controls.Add(new Dashboard());
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
