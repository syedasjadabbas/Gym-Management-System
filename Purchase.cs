using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using iText.IO.Image;

namespace GymManagement
{
    public partial class Purchase : UserControl
    {
        DataTable table;
        int Sub_total = 0;
        int Total_disc = 0;
        string id;
        int Total = 0;
        public Purchase()
        {
            InitializeComponent();
            string querry = $"select product_name ,price,product_id,stock from products where stock > 0";
            using (SqlConnection connection = new(Properties.Settings.Default.ConnectionString))
            {
                connection.Open();
                SqlDataAdapter sqlData = new(querry, connection);
                DataTable dt = new DataTable();
                sqlData.Fill(dt);

                dataGridView1.DataSource = dt;
                dt.PrimaryKey = new DataColumn[] { dt.Columns["Product_id"] };
                  

                table = new DataTable();
                table.Columns.Add("product_ID", typeof(string));
                table.Columns.Add("Name", typeof(string));
                table.Columns.Add("Price", typeof(int));
                table.Columns.Add("Quantity", typeof(int));
                table.Columns.Add("Total", typeof(int));
                table.Columns.Add("Discount", typeof(int));
                
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.All(Char.IsDigit)){
                label16.Visible = false;
            }
            else {
                label16.Visible = true;
            }
                    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!label15.Visible  && !label16.Visible)
            {
                id = dataGridView1.CurrentRow.Cells["Column8"].Value.ToString();
                int price = (int)dataGridView1.CurrentRow.Cells["Column7"].Value;
                int quantity = int.Parse(textBox2.Text);
                int total = price * quantity;
                Total += total;
                int discount = 0;
                if (textBox3.Text.Length != 0)
                {
                    discount = int.Parse(textBox3.Text);
                    Total_disc += discount;
                }
                table.PrimaryKey = new DataColumn[] { table.Columns["product_id"] };
                DataRow existingRow = table.Rows.Find(id);

                if (existingRow != null)
                {
                    existingRow["Quantity"] = (int)existingRow["Quantity"] + quantity;
                    existingRow["Total"] = (int)existingRow["Total"] + total;
                    existingRow["Discount"] = (int)existingRow["Discount"] + discount;
                }
                else
                {
                    table.Rows.Add(id, dataGridView1.CurrentRow.Cells["Column6"].Value.ToString(), price, quantity, total, discount);
                }
                dataGridView2.DataSource = table;

                Sub_total = Sub_total + (total - discount);
                label5.Text = Sub_total.ToString("#,##0");
                label13.Text = Total.ToString("#,##0");
                label11.Text = Total_disc.ToString("#,##0");
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.All(Char.IsDigit) && textBox2.Text.Length>0) {
                string id = dataGridView1.CurrentRow.Cells["Column8"].Value.ToString();
                string querry = $"select stock from products where product_id = '{id}'";
                if ((Int32.Parse(textBox2.Text)) > ((int)Helper.ScalarExecute(querry)))
                {
                    label15.Text = "Qty not in stock";
                    label15.Visible = true;
                }
                else {
                    label15.Visible = false;
                }
            }else { 
                label15.Visible = true;
                label15.Text = "Invalid Qty";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Purchase_Load(object sender, EventArgs e)
        {

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
                    $"product_name LIKE '%{filter}%' ";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(textBox4.Text)))
            {
                int balance = int.Parse(textBox4.Text) - Sub_total;
                label7.Text = balance.ToString("#,##0");
            }
            else
            {
                label7.Text = 0.ToString("#,##0");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sub_total = (Sub_total + (int)dataGridView2.CurrentRow.Cells["Column5"].Value) - (int)dataGridView2.CurrentRow.Cells["Column4"].Value;
            table.Rows.Remove(table.Rows[dataGridView2.CurrentRow.Index]);
            label5.Text = Sub_total.ToString("#,##0");
            label7.Text = Sub_total.ToString("#,##0");
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.Length > 0 && textBox4.Text.All(Char.IsDigit))
            {
                string sale_id = $"SA0{Helper.getCounter("sales")}";
                Properties.Settings.Default.Save();
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    int quantity = (int)row.Cells["Column3"].Value;
                    string id = row.Cells["Column9"].Value.ToString();

                    string querry = $"Insert into sales values ('{sale_id}','{row.Cells["Column9"].Value.ToString()}',{quantity},'{DateTime.Now.ToString("MM/dd/yyyy HH:mm")}',{row.Cells["Column5"].Value.ToString()},{row.Cells["Column4"].Value.ToString()}, {textBox4.Text})";
                    Helper.QuerryExecute(querry);
                    querry = $"select stock from products where product_id = '{id}'";
                    int quantity1 = (int)Helper.ScalarExecute(querry);
                    querry = $"Update products set Stock = {quantity1 - quantity} where product_id = '{id}'";
                    Helper.QuerryExecute(querry);

                }

                iTextSharp.text.Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4);
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Reports and Backup", "ProductInvoice.pdf");
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));

                PdfWriter writer;
                writer = PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.OpenOrCreate));
                iTextSharp.text.Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, BaseColor.BLACK);
                doc.Open();

                string query = "Select Name from gym_info";
                Paragraph header = new Paragraph((string)Helper.ScalarExecute(query), headerFont);
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

                PdfPCell Data = new PdfPCell(new Phrase(sale_id));
                Data.Border = iTextSharp.text.Rectangle.NO_BORDER;
                Data.HorizontalAlignment = Element.ALIGN_RIGHT;
                table.AddCell(Data);

                Label = new PdfPCell(new Phrase("Purchase Date"));
                Label.Border = iTextSharp.text.Rectangle.NO_BORDER;
                Label.HorizontalAlignment = Element.ALIGN_LEFT;
                table.AddCell(Label);

                Data = new PdfPCell(new Phrase(DateTime.Now.ToString("MM/dd/yyyy HH:mm")));
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

                foreach (DataGridViewColumn column in dataGridView2.Columns)
                {
                    Label = new PdfPCell(new Phrase(column.HeaderText));
                    Label.HorizontalAlignment = Element.ALIGN_LEFT;
                    Label.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    pTable.AddCell(Label);
                }

                pTable.AddCell(new PdfPCell());
                pTable.AddCell(new PdfPCell());
                pTable.AddCell(new PdfPCell());
                pTable.AddCell(new PdfPCell());
                pTable.AddCell(new PdfPCell());
                pTable.AddCell(new PdfPCell());
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        Data = new PdfPCell(new Phrase(cell.Value.ToString()));
                        Data.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        Data.HorizontalAlignment = Element.ALIGN_LEFT;
                        pTable.AddCell(Data);
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

                Data = new PdfPCell(new Phrase(Total.ToString("#,##0")));
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

                Data = new PdfPCell(new Phrase(Sub_total.ToString("#,##0")));
                Data.Border = iTextSharp.text.Rectangle.NO_BORDER;
                Data.HorizontalAlignment = Element.ALIGN_LEFT;
                table2.AddCell(Data);

                Label = new PdfPCell(new Phrase("Amount Paid"));
                Label.Border = iTextSharp.text.Rectangle.NO_BORDER;
                Label.HorizontalAlignment = Element.ALIGN_LEFT;
                table2.AddCell(Label);

                Data = new PdfPCell(new Phrase(textBox4.Text));
                Data.Border = iTextSharp.text.Rectangle.NO_BORDER;
                Data.HorizontalAlignment = Element.ALIGN_LEFT;
                table2.AddCell(Data);

                Label = new PdfPCell(new Phrase("Balance"));
                Label.Border = iTextSharp.text.Rectangle.NO_BORDER;
                Label.HorizontalAlignment = Element.ALIGN_LEFT;
                table2.AddCell(Label);

                Data = new PdfPCell(new Phrase((int.Parse(textBox4.Text) - Sub_total).ToString("#,##0")));
                Data.Border = iTextSharp.text.Rectangle.NO_BORDER;
                Data.HorizontalAlignment = Element.ALIGN_LEFT;
                table2.AddCell(Data);

                doc.Add(table2);
                doc.Close();

                MessageBox.Show("PDF Report generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                this.Controls.Clear();
                this.Controls.Add(new Purchase());

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
            else {
            label17.Visible = true;
            }

        }
    }
}
