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
    public partial class Measurements : UserControl
    {
        string id;
        ControlCollection controls;
        ControlCollection control2;
        public Measurements(string id, ControlCollection control, ControlCollection control1)
        {
            InitializeComponent();
            this.id = id;
            this.controls = control;
            control2 = control;
            Helper.SetRoundedButton(button1, 30);
            Helper.SetRoundedButton(button2, 30);
            monthCalendar1.MaxDate = DateTime.Now;
        }

        private void Measurements_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Querry = $"INSERT INTO measurements \r\nVALUES (\r\n    'MT0{Helper.getCounter("measurements")}', \r\n    '{id}', \r\n    '{monthCalendar1.SelectionStart.ToString("MM/dd/yyyy")}', \r\n    {textBox10.Text}, \r\n    {textBox9.Text}, \r\n    {textBox1.Text}, \r\n    {textBox2.Text}, \r\n    {textBox4.Text}, \r\n    {textBox3.Text}, \r\n    {textBox6.Text}, \r\n    {textBox5.Text}, \r\n    {textBox7.Text}, \r\n    {textBox8.Text}, \r\n    {textBox12.Text}, \r\n    {textBox11.Text}, \r\n    {textBox13.Text}\r\n);\r\n";
            Helper.QuerryExecute(Querry);
            controls.Clear();
            controls.Add(new User_profile(control2, id));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controls.Clear();
            controls.Add(new User_profile(control2, id));
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
