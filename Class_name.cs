using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class Class_name : Form
    {
        public Class_name()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int no = Helper.getCounter("classes");
            string querry = $"Insert into class_name values('CL0{no}','{textBox1.Text}','{textBox2.Text}')";
            Helper.QuerryExecute(querry);
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
