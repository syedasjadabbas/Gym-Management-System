namespace GymManagement
{
    partial class Purchase
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Column6 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label10 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            button3 = new Button();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Coral;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Maiandra GD", 10.2F);
            button1.Location = new Point(267, 733);
            button1.Name = "button1";
            button1.Size = new Size(127, 36);
            button1.TabIndex = 0;
            button1.Text = "Add Item";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.PeachPuff;
            dataGridViewCellStyle1.Font = new Font("Maiandra GD", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(64, 0, 0);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.FromArgb(255, 192, 128);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle2.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column6, Column8, Column7, Column10 });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(50, 250);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.SeaShell;
            dataGridViewCellStyle3.Font = new Font("Maiandra GD", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 0, 0);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(344, 472);
            dataGridView1.TabIndex = 2;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "product_name";
            Column6.HeaderText = "Name";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 175;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "product_id";
            Column8.HeaderText = "P_id";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Visible = false;
            Column8.Width = 125;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "price";
            Column7.HeaderText = "Price";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 75;
            // 
            // Column10
            // 
            Column10.DataPropertyName = "stock";
            Column10.HeaderText = "Quantity";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Width = 90;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(50, 217);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search";
            textBox1.Size = new Size(344, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Snow;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(139, 742);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(46, 27);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Maiandra GD", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(50, 744);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 5;
            label2.Text = "Quantity:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Maiandra GD", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(50, 796);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 7;
            label3.Text = "Discount:";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Snow;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(139, 794);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(83, 27);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.PeachPuff;
            dataGridViewCellStyle4.Font = new Font("Maiandra GD", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(64, 0, 0);
            dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView2.BackgroundColor = Color.FromArgb(255, 192, 128);
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle5.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.SeaShell;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle5.SelectionForeColor = Color.SeaShell;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column9, Column2, Column3, Column4, Column5 });
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.Location = new Point(518, 346);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = Color.SeaShell;
            dataGridViewCellStyle6.Font = new Font("Maiandra GD", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(64, 0, 0);
            dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(703, 218);
            dataGridView2.TabIndex = 8;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Name";
            Column1.HeaderText = "Items";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 200;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "product_id";
            Column9.HeaderText = "P_id";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Visible = false;
            Column9.Width = 125;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Price";
            Column2.HeaderText = "Unit Price";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Quantity";
            Column3.HeaderText = "Quantity";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Total";
            Column4.HeaderText = "Amount";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Discount";
            Column5.HeaderText = "Discount";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // button2
            // 
            button2.BackColor = Color.Coral;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Maiandra GD", 10.2F);
            button2.Location = new Point(1093, 570);
            button2.Name = "button2";
            button2.Size = new Size(128, 36);
            button2.TabIndex = 9;
            button2.Text = "Remove Item";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(64, 0, 0);
            label4.Font = new Font("Maiandra GD", 13.8F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(255, 224, 192);
            label4.Location = new Point(1355, 426);
            label4.Name = "label4";
            label4.Size = new Size(126, 27);
            label4.TabIndex = 10;
            label4.Text = "Net Total:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(64, 0, 0);
            label5.Font = new Font("Maiandra GD", 13.8F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(255, 224, 192);
            label5.Location = new Point(1489, 426);
            label5.Name = "label5";
            label5.Size = new Size(27, 27);
            label5.TabIndex = 11;
            label5.Text = "0";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Maiandra GD", 10.2F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(1355, 477);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 12;
            label6.Text = "Amount Paid:";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Snow;
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(1486, 475);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(83, 27);
            textBox4.TabIndex = 13;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Maiandra GD", 10.2F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(64, 0, 0);
            label7.Location = new Point(1486, 516);
            label7.Name = "label7";
            label7.Size = new Size(20, 20);
            label7.TabIndex = 15;
            label7.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Maiandra GD", 10.2F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(64, 0, 0);
            label8.Location = new Point(1355, 516);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 14;
            label8.Text = "Balance:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Maiandra GD", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.PeachPuff;
            label9.Location = new Point(119, 67);
            label9.Name = "label9";
            label9.Size = new Size(199, 48);
            label9.TabIndex = 16;
            label9.Text = "Item's List";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Location = new Point(453, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 1078);
            panel1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Maiandra GD", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.PeachPuff;
            label1.Location = new Point(751, 67);
            label1.Name = "label1";
            label1.Size = new Size(290, 45);
            label1.TabIndex = 18;
            label1.Text = "Items Purchased";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkOrange;
            panel2.Location = new Point(0, 174);
            panel2.Name = "panel2";
            panel2.Size = new Size(486, 10);
            panel2.TabIndex = 19;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkOrange;
            panel3.Location = new Point(479, 174);
            panel3.Name = "panel3";
            panel3.Size = new Size(1242, 10);
            panel3.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Maiandra GD", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.PeachPuff;
            label10.Location = new Point(1355, 70);
            label10.Name = "label10";
            label10.Size = new Size(200, 45);
            label10.TabIndex = 21;
            label10.Text = "Check Out";
            label10.Click += label10_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkOrange;
            panel4.Location = new Point(1278, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 1078);
            panel4.TabIndex = 22;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(64, 0, 0);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(label10);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1706, 181);
            panel5.TabIndex = 23;
            panel5.Paint += panel5_Paint;
            // 
            // button3
            // 
            button3.BackColor = Color.Coral;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Maiandra GD", 10.2F);
            button3.Location = new Point(1355, 560);
            button3.Name = "button3";
            button3.Size = new Size(128, 36);
            button3.TabIndex = 24;
            button3.Text = "Check Out";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Maiandra GD", 10.2F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(64, 0, 0);
            label11.Location = new Point(1489, 380);
            label11.Name = "label11";
            label11.Size = new Size(20, 20);
            label11.TabIndex = 26;
            label11.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Maiandra GD", 10.2F, FontStyle.Bold);
            label12.ForeColor = Color.FromArgb(64, 0, 0);
            label12.Location = new Point(1355, 380);
            label12.Name = "label12";
            label12.Size = new Size(136, 20);
            label12.TabIndex = 25;
            label12.Text = "Total Discount:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Maiandra GD", 10.2F, FontStyle.Bold);
            label13.ForeColor = Color.FromArgb(64, 0, 0);
            label13.Location = new Point(1489, 346);
            label13.Name = "label13";
            label13.Size = new Size(20, 20);
            label13.TabIndex = 28;
            label13.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Maiandra GD", 10.2F, FontStyle.Bold);
            label14.ForeColor = Color.FromArgb(64, 0, 0);
            label14.Location = new Point(1355, 346);
            label14.Name = "label14";
            label14.Size = new Size(92, 20);
            label14.TabIndex = 27;
            label14.Text = "Sub Total:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Maiandra GD", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(136, 768);
            label15.Name = "label15";
            label15.Size = new Size(99, 16);
            label15.TabIndex = 29;
            label15.Text = "Qty not in stock";
            label15.Visible = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Maiandra GD", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Red;
            label16.Location = new Point(136, 824);
            label16.Name = "label16";
            label16.Size = new Size(119, 16);
            label16.TabIndex = 30;
            label16.Text = "Enter Numbers only";
            label16.Visible = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Maiandra GD", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Red;
            label17.Location = new Point(1486, 500);
            label17.Name = "label17";
            label17.Size = new Size(95, 16);
            label17.TabIndex = 30;
            label17.Text = "Invalid Amount";
            label17.Visible = false;
            // 
            // Purchase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(button3);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(dataGridView2);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(panel5);
            Name = "Purchase";
            Size = new Size(1649, 1065);
            Load += Purchase_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private DataGridView dataGridView2;
        private Button button2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox4;
        private Label label7;
        private Label label8;
        private Label label9;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column10;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Label label10;
        private Panel panel4;
        private Panel panel5;
        private Button button3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
    }
}
