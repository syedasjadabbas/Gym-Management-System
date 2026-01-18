using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class Form2 : Form
    {
        public static First_page new_form;
        private string serverConnectionString;
        private SqlConnection connection;
        public Form2(string gym_name, byte[] path)
        {
            InitializeComponent();
            AcceptButton = button1;
            label1.Text = gym_name;
            Helper.SetRoundedButton(button1, 30);
            Helper.SetRoundedButton(button2, 30);
            using (MemoryStream ms = new MemoryStream(path))
            {
                pictureBox1.Image = Image.FromStream(ms);
            }
            if (!Properties.Settings.Default.IsFirstOpen)
            {
                label3.Text = "Enter Your Password:";
                button1.Text = "Login";
                label4.Text = "Welcome Back";
                label5.Text = "Login:";
                button2.Visible = false;
                label6.Visible = false;
                textBox1.Visible = false;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.IsFirstOpen)
            {
                if (textBox2.Text.Length == 0 || textBox1.Text.Length == 0)
                {
                    label2.Text = "Fill All The fields Properly";
                }
                else if (textBox2.Text.Length < 8)
                {
                    label2.Text = "Password must be atleast 8 characters";
                }
                else
                {
                    serverConnectionString = $"Server={textBox1.Text}; Integrated Security=True;";
                    string name = label1.Text.Replace(" ", "_");
                    string DatabaseName = name;
                    string createDbQuery = $"CREATE DATABASE {DatabaseName};";
                    string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Reports and Backup");
                    Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                    Properties.Settings.Default.BackupString = $" BACKUP DATABASE [{DatabaseName}] TO DISK = '{filePath}\\MyDatabase.bak' WITH FORMAT, MEDIANAME = 'MyBackupMedia'";
                    Properties.Settings.Default.Save();

                    using (connection = new SqlConnection(serverConnectionString))
                    {
                        try
                        {
                            connection.Open();

                            SqlCommand command = new SqlCommand(createDbQuery, connection);

                            command.ExecuteNonQuery();
                            serverConnectionString = $"Server={textBox1.Text}; Database={DatabaseName}; Integrated Security=True;";
                            Properties.Settings.Default.ConnectionString = serverConnectionString;
                            Properties.Settings.Default.Save();
                        }
                        catch (Exception ex)
                        {
                            label2.Text = "An error occurred: " + ex.Message;
                        }
                    }
                    string querry = "create table Counters(\r\n\tmembers int,\r\n\tmembership int,\r\n\tpayment int,\r\n\ttrainers int,\r\n\tmeasurements int,\r\n\tproducts int,\r\n\tsales int,\r\n\tclasses int,\r\n\tschedule int,\r\n\tRegistration int\r\n)      create table Gym_Info(\r\n\tname varchar(50),\r\n\timg varbinary(Max),\r\n\tpassword varchar(MAX),\r\n\tconnectionString varchar(MAX),\r\n) Create table members(\r\n\t\t\t\tmember_ID varchar(6) primary key,\r\n                name VarChar(20),\r\n                age int,\r\n                Gender Varchar(1),\r\n                PhoneNumber varchar(11),Admission_Date Date,Address Varchar(1000),Date_of_payment Date,Payment_status Bit Default 0\r\n\t\t\t\t)\r\n\r\ncreate table class_name(\r\n\tClass_id varchar(6) primary key,\r\n\tName varchar(50),\r\n\tDescription varchar(255)\r\n)\r\n\r\n\r\n\r\n\r\ncreate table trainers(\r\n\tTrainer_id varchar(6) primary key,\r\n\tFirstName varchar(20),\r\n\tLastName varchar(20),\r\n\tAddress varchar(1000),\r\n\tSalary int\r\n)\r\n\r\ncreate table classes(\r\n\tSchedule_id Varchar (6) primary key,\r\n\tStartingTime time,\r\n\tEndingTime time,\r\n\tTrainer_id varchar(6),\r\n\tForeign key (Trainer_id)references trainers(Trainer_id),\r\n\tClass_id Varchar(6),\r\n\tForeign key (Class_id) references class_name(Class_id)\r\n,Class_date   Date)\r\n\r\ncreate table membership(\r\n\tMembership_id varchar(6) primary key,\r\n\tMembershipName varchar(20),\r\n\tDescription varchar(100),\r\n\tFees int\r\n)\r\n\r\n\r\ncreate table products(\r\n\tproduct_id varChar (6) primary key,\r\n\tproduct_name varchar(50),\r\n\tproduct_desc varchar(200),\r\n\tprice int \r\n,stock int)\r\ncreate table Sales(\r\n\tsales_id varchar(6) ,\r\n\tproduct_id varchar(6),\r\n\tforeign key (product_id) references products(product_id),\r\n\tQuantity int,\r\n\tpurchase_date datetime,\r\n\tdiscount int,\r\n\ttotal int\r\n,amount_paid int,primary key(sales_id,product_id))\r\n\r\ncreate table payment(\r\n\tPayment_id varChar(6) primary key,\r\n\tMember_id varchar(6),\r\n\tforeign key (Member_id) references members(Member_id),\r\n\tMembership_id varChar(6),\r\n\tforeign key (Membership_id) references membership(Membership_id),\r\n\tPayment_date Datetime,\r\n\tPayment_medium varchar(50),\r\n\tAddNotes varchar(100) null,Discount int,Total_amount int,fees_paid int)\r\n\tcreate table measurements(\r\n\tMeasurement_Id Varchar(6) primary key,\r\n\tMemberID Varchar(6) foreign key references members(member_ID) On Delete Cascade,\r\n\tMeasurement_Date Date,\r\n\tweight_ float,\r\n\tNeck float,\r\n\tShoulders float,\r\n\tBiceps_R float,\r\n\tBiceps_L float,\r\n\tBust float,\r\n\tWaist float,\r\n\tLowerAbdomen float,\r\n\tHips Float,\r\n\tThighs_R Float,\r\n\tThighs_l float,\r\n\tCalves_R float,\r\n\tCalves_L float\r\n)";
                    Helper.QuerryExecute(querry);
                    byte[] data = File.ReadAllBytes(pictureBox1.ImageLocation);

                    string query = "INSERT INTO gym_info (Name, img, Password, ConnectionString) VALUES (@Name, @img, @Password, @ConnectionString)";

                    using (SqlConnection connection = new SqlConnection(serverConnectionString))
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@Name", label1.Text);
                                command.Parameters.AddWithValue("@img", data);
                                command.Parameters.AddWithValue("@Password", textBox2.Text);
                                command.Parameters.AddWithValue("@ConnectionString", serverConnectionString);

                                connection.Open();
                                command.ExecuteNonQuery();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    querry = "Insert into Counters values (0,0,0,0,0,0,0,0,0,0)";
                    Helper.QuerryExecute(querry);
                    Properties.Settings.Default.IsFirstOpen = false;
                    Properties.Settings.Default.Save();

                    new_form = new();
                    this.Hide();
                    new_form.ShowDialog();
                    this.Close();

                }
            }
            else
            {
                string querry = "Select password from gym_info";
                if (textBox2.Text.Equals((string)Helper.ScalarExecute(querry)))
                {
                    new_form = new();
                    this.Hide();
                    new_form.ShowDialog();
                    this.Close();
                }
                else
                {
                    label2.Text = "Invalid Password";
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Starting_Screen form = new();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
