using iTextSharp.text.pdf;
using iTextSharp.text;
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
using System.Diagnostics;

namespace GymManagement
{
    public partial class Sales : UserControl
    {
        int SubTotal;
        int NTotal;
        int Total_disc;
        int Balance;
        int amount;
        string id;
        public Sales()
        {
            InitializeComponent();
            string querry = $"Select * from products where stock > 0";
            using (SqlConnection connection = new(Properties.Settings.Default.ConnectionString))
            {
                SqlDataAdapter dataAdapter = new(querry, connection);
                DataTable data = new DataTable();
                dataAdapter.Fill(data);

                dataGridView1.DataSource = data;

                querry = $"Select * from products where stock = 0";
                dataAdapter = new(querry, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridView2.DataSource = dataTable;
                querry = $"SELECT sales_id\r\nFROM (\r\n    SELECT DISTINCT sales_id, purchase_date\r\n    FROM Sales\r\n) AS TempTable\r\nORDER BY purchase_date;";
                dataAdapter = new(querry, connection);
                DataTable data1 = new DataTable();
                dataAdapter.Fill(data1);

                dataGridView4.DataSource = data1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Sales_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Add")
            {
                string querry = $"insert into products values ('PR0{Helper.getCounter("products")}','{textBox1.Text}','{textBox2.Text}',{textBox3.Text},{textBox4.Text})";
                Helper.QuerryExecute(querry);
                Properties.Settings.Default.Save();
                this.Controls.Clear();
                this.Controls.Add(new Sales());
            }
            else
            {
                string id = dataGridView1.CurrentRow.Cells["Column1"].Value.ToString();
                string querry = $"Update products set product_name = '{textBox1.Text}', product_desc = '{textBox2.Text}',price = {textBox3.Text},stock = {textBox4.Text} where product_id = '{id}'";
                Helper.QuerryExecute(querry);
                this.Controls.Clear();
                this.Controls.Add(new Sales());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            button4.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                string Id = dataGridView2.CurrentRow.Cells["Column5"].Value.ToString();
                string querry = $"Update products Set stock = {textBox6.Text} where product_id = '{Id}'";
                Helper.QuerryExecute(querry);
            }
            this.Controls.Clear();
            this.Controls.Add(new Sales());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            button1.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string Id = dataGridView1.CurrentRow.Cells["Column1"].Value.ToString();
                int stock = (int)dataGridView1.CurrentRow.Cells["Column3"].Value + int.Parse(textBox5.Text);
                string querry = $"Update products Set stock = {stock} where product_id = '{Id}'";
                Helper.QuerryExecute(querry);
            }
            this.Controls.Clear();
            this.Controls.Add(new Sales());
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string filter = textBox7.Text;

            if (string.IsNullOrEmpty(filter))
            {
                (dataGridView4.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                (dataGridView4.DataSource as DataTable).DefaultView.RowFilter =
                    $"sales_id LIKE '%{filter}%' ";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Total_disc = 0;
            SubTotal = 0;
            id = dataGridView4.CurrentRow.Cells["ID"].Value.ToString();
            string querry = $"Select s.product_id,p.product_name,p.price,s.Quantity,s.purchase_date,s.discount,s.total,s.amount_paid from Sales s inner join products p on p.product_id = s.product_id where sales_id = '{id}'\r\n";
            using (SqlConnection connection = new(Properties.Settings.Default.ConnectionString))
            {
                connection.Open();
                SqlDataAdapter data = new(querry, connection);
                DataTable table = new DataTable();
                data.Fill(table);

                dataGridView3.DataSource = table;

            }
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                SubTotal += (int)row.Cells["Column10"].Value;
                Total_disc += (int)row.Cells["Column11"].Value;
            }
            NTotal = SubTotal - Total_disc;
            amount = (int)dataGridView3.Rows[0].Cells["Column12"].Value;
            Balance = amount - NTotal;
            label17.Text = SubTotal.ToString();
            label20.Text = Total_disc.ToString();
            label22.Text = NTotal.ToString();
            label19.Text = amount.ToString();
            label14.Text = Balance.ToString();
            label25.Text = dataGridView3.Rows[0].Cells["Column9"].Value.ToString();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            iTextSharp.text.Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4);
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Reports and Backup", "ProductInvoice.pdf");
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));

            PdfWriter writer;
            writer = PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.OpenOrCreate));
            iTextSharp.text.Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, BaseColor.BLACK);
            doc.Open();

            string querry = "Select name from gym_info";
            Paragraph header = new Paragraph((string)Helper.ScalarExecute(querry), headerFont);
            header.Alignment = Element.ALIGN_CENTER;
            header.SpacingBefore = 70;
            header.SpacingAfter = 50;
            doc.Add(header);

            PdfPTable table = new PdfPTable(2);
            table.WidthPercentage = 70;
            table.HorizontalAlignment = Element.ALIGN_CENTER;
            table.SetWidths(new float[] { 50f, 50f });
            table.SpacingBefore = 5;
            table.SpacingAfter = 5;

            PdfPCell Label = new PdfPCell(new Phrase("Reciept No"));
            Label.Border = iTextSharp.text.Rectangle.NO_BORDER;
            Label.HorizontalAlignment = Element.ALIGN_LEFT;
            table.AddCell(Label);

            PdfPCell Data = new PdfPCell(new Phrase(id));
            Data.Border = iTextSharp.text.Rectangle.NO_BORDER;
            Data.HorizontalAlignment = Element.ALIGN_RIGHT;
            table.AddCell(Data);

            Label = new PdfPCell(new Phrase("Purchase Date"));
            Label.Border = iTextSharp.text.Rectangle.NO_BORDER;
            Label.HorizontalAlignment = Element.ALIGN_LEFT;
            table.AddCell(Label);

            Data = new PdfPCell(new Phrase(dataGridView3.Rows[0].Cells["Column9"].Value.ToString()));
            Data.Border = iTextSharp.text.Rectangle.NO_BORDER;
            Data.HorizontalAlignment = Element.ALIGN_RIGHT;
            table.AddCell(Data);
            doc.Add(table);


            PdfPTable pTable = new PdfPTable(6);
            pTable.WidthPercentage = 80;
            pTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pTable.SpacingBefore = 5;
            pTable.SpacingAfter = 5;

            pTable.AddCell(new PdfPCell());
            pTable.AddCell(new PdfPCell());
            pTable.AddCell(new PdfPCell());
            pTable.AddCell(new PdfPCell());
            pTable.AddCell(new PdfPCell());
            pTable.AddCell(new PdfPCell());

            foreach (DataGridViewColumn column in dataGridView3.Columns)
            {
                if (column.Visible == true)
                {
                    Label = new PdfPCell(new Phrase(column.HeaderText));
                    Label.HorizontalAlignment = Element.ALIGN_LEFT;
                    Label.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    pTable.AddCell(Label);
                }
            }

            pTable.AddCell(new PdfPCell());
            pTable.AddCell(new PdfPCell());
            pTable.AddCell(new PdfPCell());
            pTable.AddCell(new PdfPCell());
            pTable.AddCell(new PdfPCell());
            pTable.AddCell(new PdfPCell());
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Visible)
                    {
                        Data = new PdfPCell(new Phrase(cell.Value.ToString()));
                        Data.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        Data.HorizontalAlignment = Element.ALIGN_LEFT;
                        pTable.AddCell(Data);
                    }

                }
            }
            pTable.AddCell(new PdfPCell());
            pTable.AddCell(new PdfPCell());
            pTable.AddCell(new PdfPCell());
            pTable.AddCell(new PdfPCell());
            pTable.AddCell(new PdfPCell());
            pTable.AddCell(new PdfPCell());
            doc.Add(pTable);

            PdfPTable table2 = new PdfPTable(2);
            table2.WidthPercentage = 40;
            table2.HorizontalAlignment = Element.ALIGN_RIGHT;
            table2.SetWidths(new float[] { 50f, 50f });
            table2.SpacingBefore = 5;
            table2.SpacingAfter = 5;

            Label = new PdfPCell(new Phrase("Sub Total"));
            Label.Border = iTextSharp.text.Rectangle.NO_BORDER;
            Label.HorizontalAlignment = Element.ALIGN_LEFT;
            table2.AddCell(Label);

            Data = new PdfPCell(new Phrase(SubTotal.ToString("#,##0")));
            Data.Border = iTextSharp.text.Rectangle.NO_BORDER;
            Data.HorizontalAlignment = Element.ALIGN_LEFT;
            table2.AddCell(Data);


            Label = new PdfPCell(new Phrase("Total Discount"));
            Label.Border = iTextSharp.text.Rectangle.NO_BORDER;
            Label.HorizontalAlignment = Element.ALIGN_LEFT;
            table2.AddCell(Label);

            Data = new PdfPCell(new Phrase(Total_disc.ToString("#,##0")));
            Data.Border = iTextSharp.text.Rectangle.NO_BORDER;
            Data.HorizontalAlignment = Element.ALIGN_LEFT;
            table2.AddCell(Data);

            Label = new PdfPCell(new Phrase("Total"));
            Label.Border = iTextSharp.text.Rectangle.NO_BORDER;
            Label.HorizontalAlignment = Element.ALIGN_LEFT;
            table2.AddCell(Label);

            Data = new PdfPCell(new Phrase(NTotal.ToString("#,##0")));
            Data.Border = iTextSharp.text.Rectangle.NO_BORDER;
            Data.HorizontalAlignment = Element.ALIGN_LEFT;
            table2.AddCell(Data);

            Label = new PdfPCell(new Phrase("Amount Paid"));
            Label.Border = iTextSharp.text.Rectangle.NO_BORDER;
            Label.HorizontalAlignment = Element.ALIGN_LEFT;
            table2.AddCell(Label);

            Data = new PdfPCell(new Phrase(amount.ToString("#,##0")));
            Data.Border = iTextSharp.text.Rectangle.NO_BORDER;
            Data.HorizontalAlignment = Element.ALIGN_LEFT;
            table2.AddCell(Data);

            Label = new PdfPCell(new Phrase("Balance"));
            Label.Border = iTextSharp.text.Rectangle.NO_BORDER;
            Label.HorizontalAlignment = Element.ALIGN_LEFT;
            table2.AddCell(Label);

            Data = new PdfPCell(new Phrase(Balance.ToString("#,##0")));
            Data.Border = iTextSharp.text.Rectangle.NO_BORDER;
            Data.HorizontalAlignment = Element.ALIGN_LEFT;
            table2.AddCell(Data);

            doc.Add(table2);
            doc.Close();

            MessageBox.Show("PDF Report generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (System.IO.File.Exists(filePath))
            {
                Process process = new Process();
                process.StartInfo = new ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true
                };
                process.Start();
            }
            else
            {
                MessageBox.Show("The file could not be found!");
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            textBox1.Text = dataGridView1.CurrentRow.Cells["Column2"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["Column13"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["Column3"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["Column4"].Value.ToString();
            label2.Text = "Update a product";
            button5.Text = "Update";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["Column2"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["Column13"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["Column3"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["Column4"].Value.ToString();
        }
    }
}
