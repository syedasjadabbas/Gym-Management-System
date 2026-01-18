using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Drawing.Printing;
using System.Data.Common;
using System.Diagnostics;

namespace GymManagement
{
    public partial class Payment : UserControl
    {
        public Payment()
        {
            InitializeComponent();
            comboBox1.Items.Add("Card Payment");
            comboBox1.Items.Add("Cash");
            comboBox1.Items.Add("Online Transaction");
            string Querry = $"Select p.Payment_id,m.name,p.Payment_date,m.Date_of_payment,p.Payment_medium,p.fees_paid,p.discount,p.Total_amount  from payment p inner join membership mm on p.Membership_id = mm.Membership_id inner join members m on p.Member_id = m.member_ID";
            using (SqlConnection connection = new(Properties.Settings.Default.ConnectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new(Querry, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataTable.Columns.Add("Registration", typeof(int));
                foreach (DataRow row in dataTable.Rows)
                {
                    int totalAmount = row["Total_amount"] != DBNull.Value ? (int)row["Total_amount"] : 0;
                    int discount = row["discount"] != DBNull.Value ? (int)row["discount"] : 0;
                    int fees = row["fees_paid"] != DBNull.Value ? (int)row["fees_paid"] : 0;

                    row["Registration"] = (totalAmount + discount) - fees;
                }
                dataTable.Columns["registration"].SetOrdinal(dataTable.Columns["discount"].Ordinal);

                dataGridView1.DataSource = dataTable;
                Querry = "SELECT p.payment_id,p.Addnotes,m.member_id,m.name,p.payment_date,p.discount, mem.membershipname,p.total_amount,m.PhoneNumber,m.date_of_payment FROM members m INNER JOIN     payment p ON m.member_id = p.member_id INNER JOIN  membership mem ON p.membership_id = mem.membership_id WHERE  p.payment_date = (  SELECT MAX(payment_date) FROM payment WHERE payment.member_id = m.member_id ) ORDER BY  p.payment_date DESC;\r\n";
                SqlDataAdapter dataAdapter = new(Querry, connection);
                DataTable data = new();
                dataAdapter.Fill(data);

                dataGridView2.DataSource = data;
            }
        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to generate the report.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                iTextSharp.text.Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4);
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Reports and Backup", "FeesPaymentReport.pdf");
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));


                PdfWriter writer;
                writer = PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.OpenOrCreate));
                iTextSharp.text.Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, BaseColor.BLACK);
                doc.Open();

                string querry = "Select Name from Gym_info";
                Paragraph header = new Paragraph((string)Helper.ScalarExecute(querry), headerFont);
                header.Alignment = Element.ALIGN_CENTER;
                header.SpacingBefore = 10;
                header.SpacingAfter = 30;
                doc.Add(header);

                PdfPTable table = new PdfPTable(2);
                table.WidthPercentage = 50;
                table.HorizontalAlignment = Element.ALIGN_CENTER;
                table.SetWidths(new float[] { 70f, 30f });
                table.SpacingBefore = 5;
                table.SpacingAfter = 5;
                int i = 0;

                table.AddCell(new PdfPCell());
                table.AddCell(new PdfPCell());
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    if (i < 6)
                    {

                        PdfPCell Label = new PdfPCell(new Phrase(column.HeaderText));
                        Label.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        Label.HorizontalAlignment = Element.ALIGN_LEFT;
                        table.AddCell(Label);

                        PdfPCell Data = new PdfPCell(new Phrase(dataGridView1.CurrentRow.Cells[i++].Value.ToString()));
                        Data.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        Data.HorizontalAlignment = Element.ALIGN_RIGHT;
                        table.AddCell(Data);

                    }
                    else {
                        if (i == 6)
                        {
                            table.AddCell(new PdfPCell());
                            table.AddCell(new PdfPCell());
                        }
                        PdfPCell Label = new PdfPCell(new Phrase(column.HeaderText));
                        Label.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        Label.HorizontalAlignment = Element.ALIGN_RIGHT;
                        table.AddCell(Label);

                        PdfPCell Data = new PdfPCell(new Phrase(dataGridView1.CurrentRow.Cells[i++].Value.ToString()));
                        Data.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        Data.HorizontalAlignment = Element.ALIGN_RIGHT;
                        table.AddCell(Data);
                    }

                }
                doc.Add(table);
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
            catch (Exception ex)
            { 
                MessageBox.Show($"An error occurred while generating the report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            splitContainer1.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string id = dataGridView2.CurrentRow.Cells["Column1"].Value.ToString();
            string membership = dataGridView2.CurrentRow.Cells["Column4"].Value.ToString();
            DateTime date = (DateTime)dataGridView2.CurrentRow.Cells["Column7"].Value;
            int fees = 0;
            int total=0;
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string querry2 = $"select Membership_id from membership\r\nwhere MembershipName = '{membership}'";
                    membership = (string)Helper.ScalarExecute(querry2);
                    String Querry = $"select fees from membership where membership_id = '{membership}'";
                    fees = (int)Helper.ScalarExecute(Querry);
                    total = fees - Int32.Parse(textBox2.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            string querry = $"Insert into payment values('PA0{Helper.getCounter("payment")}','{id}','{membership}','{DateTime.Now.ToString("MM/dd/yyyy HH:mm")}','{comboBox1.Text}','{textBox1.Text}',{textBox2.Text},{total},{fees}) update members Set date_of_payment = '{date.AddMonths(1).ToString("MM/dd/yyyy")}' WHERE Member_id = '{id}'";
            Helper.QuerryExecute(querry);
            Properties.Settings.Default.Save();
            this.Controls.Clear();
            this.Controls.Add(new Payment());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            splitContainer1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            button4_Click(sender, e);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }
    }
}
