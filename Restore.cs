using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class Restore : Form
    {
        public Restore()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Select a file";
            string file = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                file = openFileDialog.FileName;

            }
            textBox2.Text = file;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text == ""))
            {
                string serverConnectionString = $"Server={textBox1.Text}; Integrated Security=True;";
                string querry = $"Restore Database {textBox3.Text.Replace(" ", "_")} From Disk = '{textBox2.Text}' With Replace";
                using (SqlConnection connection = new(serverConnectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand command = new(querry, connection);
                        command.ExecuteNonQuery();
                        Properties.Settings.Default.ConnectionString = $"Server={textBox1.Text}; Database={textBox3.Text.Replace(" ", "_")}; Integrated Security=True;";
                        Properties.Settings.Default.Save();
                        string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Reports and Backup");
                        Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                        Properties.Settings.Default.BackupString = $" BACKUP DATABASE [{textBox3.Text.Replace(" ", "_")}] TO DISK = '{filePath}\\MyDatabase.bak' WITH FORMAT, MEDIANAME = 'MyBackupMedia'";
                        Properties.Settings.Default.IsFirstOpen = false;
                        Properties.Settings.Default.Save();
                        querry = "Select Name from Gym_info";
                        string name = (string)Helper.ScalarExecute(querry);
                        querry = "Select img from Gym_info";

                        Form2 form = new(name, (byte[])Helper.ScalarExecute(querry));
                        this.Hide();
                        form.ShowDialog();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                label2.Visible = true;
            }
        }
    }
}
