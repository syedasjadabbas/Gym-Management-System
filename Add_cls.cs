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
    public partial class Add_cls : Form
    {
        public Add_cls()
        {
            InitializeComponent();

            using (SqlConnection connection = new(Properties.Settings.Default.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string Querry = $"Select Name from class_name";
                    SqlCommand sqlCommand = new SqlCommand(Querry, connection);
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
                    comboBox2.Text = Properties.Settings.Default.trainer;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            string querry = $"Select Class_id from class_name where name = '{comboBox1.Text}'";
            string cls = Helper.ScalarExecute(querry).ToString();
            querry = $"Select trainer_id from trainers where firstname = '{comboBox2.Text}'";
            string trainer = Helper.ScalarExecute(querry).ToString();
            querry = $"Insert into classes values ( 'SH0{Helper.getCounter("Schedule")}','{dateTimePicker1.Value.ToString("HH:mm:ss")}','{dateTimePicker2.Value.ToString("HH:mm:ss")}', '{trainer}','{cls}' ,'{dateTimePicker3.Value.ToString("MM/dd/yyyy")}')";
            Helper.QuerryExecute(querry);
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
