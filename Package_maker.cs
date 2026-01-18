using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class Package_maker : Form
    {
        public Package_maker()
        {
            InitializeComponent();
            Helper.SetRoundedButton(button1, 30);
        }

        private void Package_maker_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string desc = textBox2.Text;
            string fee = textBox3.Text;
            string querry = $"insert into membership values('MS0{Helper.getCounter("membership")}','{name}', '{desc}',{fee})";

            Helper.QuerryExecute(querry);
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
