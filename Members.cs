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
    public partial class Members : UserControl
    {
        public Panel panel;
        public Members()
        {
            InitializeComponent();
            panel = panel1;
            Dock = DockStyle.Fill;
            
            using (SqlConnection connection = new(Properties.Settings.Default.ConnectionString))
            {
                try
                {
                    string Querry = "Select name,member_ID from members";
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(Querry, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadControl(new Member_form(this.Controls));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string rollno = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            LoadControl(new User_profile(this.Controls, rollno));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                string filter = textBox1.Text;

                if (string.IsNullOrEmpty(filter))
                {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                }
                else
                {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
                        $"Name LIKE '%{filter}%' OR Member_ID LIKE '%{filter}%' ";
                }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void LoadControl(UserControl control)
        {
            panel1.Controls.Clear();

            control.Dock = DockStyle.Fill;
            panel1.Controls.Add(control);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Querry = $"Delete from payment where Member_id = '{dataGridView1.CurrentRow.Cells[1].Value.ToString()}'\r\n\tDelete from members where Member_id='{dataGridView1.CurrentRow.Cells[1].Value.ToString()}'";
            Helper.QuerryExecute(Querry);
            this.Controls.Clear();
            this.Controls.Add(new Members());

        }

        private void Members_Load(object sender, EventArgs e)
        {

        }
    }
}
