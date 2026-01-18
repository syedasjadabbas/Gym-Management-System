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
    public partial class Store : UserControl
    {
        Button active_button = null;

        public void SetActiveButton(Button button) {
            if (active_button != null) 
            {
                active_button.BackColor = panel1.BackColor;
                active_button.ForeColor = Color.Black;
            } 
            active_button = button;
            active_button.BackColor = Color.FromArgb(64,0,0);
            active_button.ForeColor = Color.White;

        }
        public Store()
        {
            InitializeComponent();
            iTextSharp.text.Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4);
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Reports", "ProductInvoice.pdf");
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
        }

        private void Sales_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            SetActiveButton(button1);
            panel1.Controls.Clear();
            panel1.Controls.Add(new Purchase());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SetActiveButton(button2);
            panel1.Controls.Clear();
            panel1.Controls.Add(new Sales());
        }
    }
}
