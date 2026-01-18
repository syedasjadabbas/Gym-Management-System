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
    public partial class Add_Trainer : Form
    {
        public Add_Trainer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int no = Helper.getCounter("trainers");
            string Querry = $"Insert into trainers values ('TR0{no}','{textBox1.Text}','{textBox3.Text}','{textBox2.Text}',{textBox4.Text})";
            Helper.QuerryExecute(Querry);
            no++;
            Querry = "Update Counters set trainers =";
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void Add_Trainer_Load(object sender, EventArgs e)
        {

        }
    }
}
