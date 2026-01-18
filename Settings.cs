using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GymManagement
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();

            string querry = "Select Name from Gym_info";
            textBox9.Text = (string)Helper.ScalarExecute(querry);
            label5.Text = Helper.getCounter("Registration").ToString("#,##0");
            using (SqlConnection connection = new(Properties.Settings.Default.ConnectionString))
            {
                connection.Open();
                querry = $"Select * from trainers";
                SqlDataAdapter dataAdapter = new(querry, connection);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                dataGridView1.DataSource = dt;
                querry = $"Select * from membership";
                dataAdapter = new(querry, connection);
                DataTable data = new DataTable();
                dataAdapter.Fill(data);

                dataGridView2.DataSource = data;

                querry = $"Select * from class_name";
                dataAdapter = new(querry, connection);
                DataTable data2 = new DataTable();
                dataAdapter.Fill(data2);

                dataGridView3.DataSource = data2;
                querry = $"Select FirstName from trainers";
                SqlCommand sqlCommand = new SqlCommand(querry, connection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    comboBox1.Items.Add(sqlDataReader["FirstName"].ToString());
                }
                sqlDataReader.Close();
            }
            comboBox1.Text = Properties.Settings.Default.trainer;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Package_maker package_Maker = new Package_maker();
            package_Maker.ShowDialog();
            this.Controls.Clear();
            this.Controls.Add(new Settings());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Add_Trainer trainer = new Add_Trainer();
            trainer.ShowDialog();
            this.Controls.Clear();
            this.Controls.Add(new Settings());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Class_name class_Name = new Class_name();
            class_Name.ShowDialog();
            this.Controls.Clear();
            this.Controls.Add(new Settings());
        }

        private void button9_Click(object sender, EventArgs e)
        {

            string querry = $"Update Counters set registration = {textBox2.Text}";
            Helper.QuerryExecute(querry);
            this.Controls.Clear();
            this.Controls.Add(new Settings());
        }

        private void button10_Click(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.trainer = comboBox1.Text;
            Properties.Settings.Default.Save();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            textBox3.Text = dataGridView2.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value.ToString();
            textBox4.Text = dataGridView2.CurrentRow.Cells["dataGridViewTextBoxColumn3"].Value.ToString();
            textBox1.Text = dataGridView2.CurrentRow.Cells["dataGridViewTextBoxColumn2"].Value.ToString();

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            string id = dataGridView2.CurrentRow.Cells["Column9"].Value.ToString();
            string querry = $"Update membership set membershipname = '{textBox3.Text}',Description = '{textBox1.Text}',Fees = {textBox4.Text} where membership_id = '{id}'";
            Helper.QuerryExecute(querry);
            this.Controls.Clear();
            this.Controls.Add(new Settings());

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = dataGridView2.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value.ToString();
            textBox4.Text = dataGridView2.CurrentRow.Cells["dataGridViewTextBoxColumn3"].Value.ToString();
            textBox1.Text = dataGridView2.CurrentRow.Cells["dataGridViewTextBoxColumn2"].Value.ToString();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
            textBox6.Text = dataGridView1.CurrentRow.Cells["dataGridViewTextBoxColumn5"].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells["dataGridViewTextBoxColumn6"].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells["dataGridViewTextBoxColumn7"].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells["Column1"].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox6.Text = dataGridView1.CurrentRow.Cells["dataGridViewTextBoxColumn5"].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells["dataGridViewTextBoxColumn6"].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells["dataGridViewTextBoxColumn7"].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells["Column1"].Value.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells["dataGridViewTextBoxColumn4"].Value.ToString();
            string querry = $"Update trainers set Firstname = '{textBox6.Text}',Address = '{textBox7.Text}',Salary = {textBox5.Text},Lastname = '{textBox8.Text}' where trainer_id = '{id}'";
            Helper.QuerryExecute(querry);
            this.Controls.Clear();
            this.Controls.Add(new Settings());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            panel7.Visible = true;
            textBox10.Text = dataGridView3.CurrentRow.Cells["dataGridViewTextBoxColumn9"].Value.ToString();
            textBox11.Text = dataGridView3.CurrentRow.Cells["dataGridViewTextBoxColumn11"].Value.ToString();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            string id = dataGridView3.CurrentRow.Cells["dataGridViewTextBoxColumn8"].Value.ToString();
            string querry = $"Update class_name set Name = '{textBox10.Text}',Description = '{textBox11.Text}' where class_id = '{id}'";
            Helper.QuerryExecute(querry);
            this.Controls.Clear();
            this.Controls.Add(new Settings());
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox10.Text = dataGridView3.CurrentRow.Cells["dataGridViewTextBoxColumn9"].Value.ToString();
            textBox11.Text = dataGridView3.CurrentRow.Cells["dataGridViewTextBoxColumn11"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells["dataGridViewTextBoxColumn4"].Value.ToString();
            string querry = $"Delete from classes where trainer_id = '{id}' Delete from trainers where trainer_id = '{id}'";
            Helper.QuerryExecute(querry);
            this.Controls.Clear();
            this.Controls.Add(new Settings());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox9.Text != "")
            {
                string querry = $"Update Gym_info set name = '{textBox9.Text}'";
                Helper.QuerryExecute(querry);
                Form2.new_form.Hide();
                Form2.new_form = new();
                Form2.new_form.ShowDialog();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "JPEG Files|*.jpeg;*.jpg|PNG Files|*.png|All Files|*.*";
            openFileDialog.Title = "Select an Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;
                button17.Visible = true;
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            byte[] imag = File.ReadAllBytes(pictureBox1.ImageLocation);
            string querry = "Select connectionString from Gym_info";
            string query = "Update Gym_info set img = @imag";
            using (SqlConnection connection = new SqlConnection((string)Helper.ScalarExecute(querry)))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@imag", imag);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    Form2.new_form.Hide();
                    Form2.new_form = new();
                    Form2.new_form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            panel8.Visible = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            panel8.Visible = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox13.Text == ((string)Helper.ScalarExecute("Select password from Gym_info")))
            {
                string Querry = $"Update Gym_info set password = '{textBox12.Text}'";
                Helper.QuerryExecute(Querry);
                panel8.Visible = false;
            }
            else
            {
                label23.Visible = true;
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            label23.Visible=false;
        }
    }
}
          
