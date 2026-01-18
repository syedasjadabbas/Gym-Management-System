using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GymManagement
{
    public partial class Form1 : Form
    {
        public static string notes;
        public static string medium;
        public static int fees;

        public Form1()
        {
            InitializeComponent();
            AcceptButton = button1;
            comboBox1.Items.Add("Card Payment");
            comboBox1.Items.Add("Cash");
            comboBox1.Items.Add("Online Transaction");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Helper.flag = 1;
            notes = textBox1.Text;
            medium = comboBox1.Text;
            fees = int.Parse(textBox2.Text);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Helper.flag = 0;
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
