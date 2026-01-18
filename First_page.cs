using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection.Emit;
using iText.IO.Image;

namespace GymManagement
{
    public partial class First_page : Form
    {
        private Button activeButton = null;
        public static bool is_going = false;
        public static DateTime time = DateTime.Now;

        private void SetActiveButton(Button clickedButton)
        {
            if (activeButton != null)
            {
                activeButton.BackColor = flowLayoutPanel1.BackColor;
            }
            activeButton = clickedButton;


            activeButton.BackColor = Color.OrangeRed;
        }

        public First_page()
        {

            InitializeComponent();
            string querry = $"Select img from gym_info";
            byte[] image = (byte[])Helper.ScalarExecute(querry);
            using (MemoryStream ms = new MemoryStream(image)) {
                pictureBox1.Image = Image.FromStream(ms);
            }
            querry = $"Select name from Gym_info";
            label1.Text = (string)Helper.ScalarExecute(querry);
            Helper.SetRoundedButton(button1, 70);
            Helper.SetRoundedButton(button2, 70);
            Helper.SetRoundedButton(button3, 70);
            Helper.SetRoundedButton(button4, 70);
            Helper.SetRoundedButton(button5, 70);

            LoadControl(new Dashboard());
            SetActiveButton(button1);
        }

        private void First_page_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadControl(new Dashboard());
            SetActiveButton(button1);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadControl(new Payment());
            SetActiveButton(button5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadControl(new Members());
            SetActiveButton(button2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadControl(new Settings());
            SetActiveButton(button4);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            LoadControl(new Store());
            SetActiveButton(button3);
        }

        private void LoadControl(UserControl control)
        {
            panel1.Controls.Clear();

            control.Dock = DockStyle.Fill;
            panel1.Controls.Add(control);

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
