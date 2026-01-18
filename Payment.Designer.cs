namespace GymManagement
{
    partial class Payment
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column18 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            Column17 = new DataGridViewTextBoxColumn();
            Column16 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            panel1 = new Panel();
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column19 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column20 = new DataGridViewTextBoxColumn();
            label10 = new Label();
            button2 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            splitContainer1 = new SplitContainer();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            button3 = new Button();
            button4 = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.PeachPuff;
            dataGridViewCellStyle1.Font = new Font("Maiandra GD", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(64, 0, 0);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.IndianRed;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle2.Font = new Font("Maiandra GD", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.InactiveBorder;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column9, Column10, Column12, Column13, Column18, Column14, Column17, Column16, Column15 });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(276, 88);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.SeaShell;
            dataGridViewCellStyle3.Font = new Font("Maiandra GD", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 0, 0);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1072, 389);
            dataGridView1.TabIndex = 0;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "payment_id";
            Column9.HeaderText = "Transaction ID";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 140;
            // 
            // Column10
            // 
            Column10.DataPropertyName = "name";
            Column10.HeaderText = "Name";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Resizable = DataGridViewTriState.False;
            Column10.Width = 86;
            // 
            // Column12
            // 
            Column12.DataPropertyName = "payment_date";
            Column12.HeaderText = "Payment Date";
            Column12.MinimumWidth = 6;
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            Column12.Resizable = DataGridViewTriState.False;
            Column12.Width = 137;
            // 
            // Column13
            // 
            Column13.DataPropertyName = "date_of_payment";
            Column13.HeaderText = "Valid Till";
            Column13.MinimumWidth = 6;
            Column13.Name = "Column13";
            Column13.ReadOnly = true;
            Column13.Resizable = DataGridViewTriState.False;
            Column13.Width = 102;
            // 
            // Column18
            // 
            Column18.DataPropertyName = "payment_medium";
            Column18.HeaderText = "Payment Type";
            Column18.MinimumWidth = 6;
            Column18.Name = "Column18";
            Column18.ReadOnly = true;
            Column18.Width = 138;
            // 
            // Column14
            // 
            Column14.DataPropertyName = "fees_paid";
            Column14.HeaderText = "Fee";
            Column14.MinimumWidth = 6;
            Column14.Name = "Column14";
            Column14.ReadOnly = true;
            Column14.Width = 66;
            // 
            // Column17
            // 
            Column17.DataPropertyName = "Total_amount";
            Column17.HeaderText = "Total Amount";
            Column17.MinimumWidth = 6;
            Column17.Name = "Column17";
            Column17.ReadOnly = true;
            Column17.Width = 137;
            // 
            // Column16
            // 
            Column16.DataPropertyName = "discount";
            Column16.HeaderText = "Discount";
            Column16.MinimumWidth = 6;
            Column16.Name = "Column16";
            Column16.ReadOnly = true;
            Column16.Width = 108;
            // 
            // Column15
            // 
            Column15.DataPropertyName = "registration";
            Column15.HeaderText = "Registration Fee";
            Column15.MinimumWidth = 6;
            Column15.Name = "Column15";
            Column15.ReadOnly = true;
            Column15.Width = 151;
            // 
            // button1
            // 
            button1.BackColor = Color.Chocolate;
            button1.CausesValidation = false;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(1199, 483);
            button1.Name = "button1";
            button1.Size = new Size(172, 44);
            button1.TabIndex = 1;
            button1.Text = "Generate Reciept";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView2);
            panel1.Location = new Point(37, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(956, 354);
            panel1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.PeachPuff;
            dataGridViewCellStyle4.Font = new Font("Maiandra GD", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.BackgroundColor = Color.Coral;
            dataGridView2.BorderStyle = BorderStyle.Fixed3D;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle5.Font = new Font("Maiandra GD", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column4, Column3, Column7, Column5, Column19, Column6, Column8, Column20 });
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.GridColor = SystemColors.ActiveCaptionText;
            dataGridView2.ImeMode = ImeMode.Off;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.MinimumSize = new Size(50, 50);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.SeaShell;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.SeaShell;
            dataGridViewCellStyle10.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(956, 354);
            dataGridView2.TabIndex = 1;
            dataGridView2.TabStop = false;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.DataPropertyName = "Member_id";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle6.Font = new Font("Maiandra GD", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            Column1.DefaultCellStyle = dataGridViewCellStyle6;
            Column1.HeaderText = "Roll No";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.True;
            Column1.Width = 68;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.DataPropertyName = "name";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle7.Font = new Font("Maiandra GD", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            Column2.DefaultCellStyle = dataGridViewCellStyle7;
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Resizable = DataGridViewTriState.True;
            Column2.Width = 80;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "MembershipName";
            Column4.HeaderText = "Membership";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 127;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.DataPropertyName = "Payment_date";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.Red;
            dataGridViewCellStyle8.Font = new Font("Maiandra GD", 7.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(64, 0, 64);
            Column3.DefaultCellStyle = dataGridViewCellStyle8;
            Column3.HeaderText = "Last Payment";
            Column3.MinimumWidth = 25;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Resizable = DataGridViewTriState.True;
            Column3.Width = 122;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "date_of_payment";
            Column7.HeaderText = "Fees Date";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 99;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "total_amount";
            Column5.HeaderText = "Fees Paid";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 97;
            // 
            // Column19
            // 
            Column19.DataPropertyName = "discount";
            Column19.HeaderText = "Discount";
            Column19.MinimumWidth = 6;
            Column19.Name = "Column19";
            Column19.ReadOnly = true;
            Column19.Width = 101;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "PhoneNumber";
            Column6.HeaderText = "Phone Number";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 134;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "addNotes";
            Column8.HeaderText = "Notes";
            Column8.MinimumWidth = 100;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Resizable = DataGridViewTriState.False;
            // 
            // Column20
            // 
            Column20.DataPropertyName = "payment_id";
            Column20.HeaderText = "P_id";
            Column20.MinimumWidth = 6;
            Column20.Name = "Column20";
            Column20.ReadOnly = true;
            Column20.Visible = false;
            Column20.Width = 70;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(128, 64, 64);
            label10.Font = new Font("Maiandra GD", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(255, 224, 192);
            label10.Location = new Point(686, 29);
            label10.Name = "label10";
            label10.Size = new Size(282, 41);
            label10.TabIndex = 33;
            label10.Text = "Payment History";
            // 
            // button2
            // 
            button2.BackColor = Color.Chocolate;
            button2.CausesValidation = false;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(830, 440);
            button2.Name = "button2";
            button2.Size = new Size(163, 36);
            button2.TabIndex = 34;
            button2.Text = "Payment Recieved";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Maiandra GD", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(398, 18);
            label1.Name = "label1";
            label1.Size = new Size(233, 41);
            label1.TabIndex = 35;
            label1.Text = "Member's List";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 64, 64);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label10);
            panel2.Location = new Point(0, 495);
            panel2.Name = "panel2";
            panel2.Size = new Size(1783, 663);
            panel2.TabIndex = 36;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 61);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(64, 0, 0);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label4);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.LightSalmon;
            splitContainer1.Panel2.Controls.Add(textBox2);
            splitContainer1.Panel2.Controls.Add(textBox1);
            splitContainer1.Panel2.Controls.Add(comboBox1);
            splitContainer1.Size = new Size(534, 176);
            splitContainer1.SplitterDistance = 211;
            splitContainer1.TabIndex = 39;
            splitContainer1.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Maiandra GD", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.PeachPuff;
            label3.Location = new Point(21, 23);
            label3.Name = "label3";
            label3.Size = new Size(143, 21);
            label3.TabIndex = 6;
            label3.Text = "Discount (If Any)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Maiandra GD", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.PeachPuff;
            label2.Location = new Point(21, 91);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 5;
            label2.Text = "Notes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Maiandra GD", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.PeachPuff;
            label4.Location = new Point(21, 62);
            label4.Name = "label4";
            label4.Size = new Size(149, 21);
            label4.TabIndex = 4;
            label4.Text = "Payment Medium";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(32, 21);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(76, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(32, 89);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 66);
            textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(32, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkOrange;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Maiandra GD", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.DarkRed;
            button3.Location = new Point(160, 258);
            button3.Name = "button3";
            button3.Size = new Size(128, 36);
            button3.TabIndex = 38;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = false;
            button3.Visible = false;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkOrange;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Maiandra GD", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.DarkRed;
            button4.Location = new Point(12, 258);
            button4.Name = "button4";
            button4.Size = new Size(142, 36);
            button4.TabIndex = 37;
            button4.Text = "Confirm";
            button4.UseVisualStyleBackColor = false;
            button4.Visible = false;
            button4.Click += button4_Click_1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 224, 192);
            panel3.Controls.Add(splitContainer1);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button4);
            panel3.Location = new Point(1060, 76);
            panel3.Name = "panel3";
            panel3.Size = new Size(581, 354);
            panel3.TabIndex = 40;
            panel3.Paint += panel3_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 0, 0);
            panel4.ForeColor = SystemColors.ControlLightLight;
            panel4.Location = new Point(-20, 495);
            panel4.Name = "panel4";
            panel4.Size = new Size(1744, 10);
            panel4.TabIndex = 41;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(64, 0, 0);
            panel5.Location = new Point(1028, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 502);
            panel5.TabIndex = 42;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(panel1);
            Name = "Payment";
            Size = new Size(1721, 1174);
            Load += Payment_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Panel panel1;
        private DataGridView dataGridView2;
        private Label label10;
        private Button button2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column19;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column20;
        private Label label1;
        private Panel panel2;
        private SplitContainer splitContainer1;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button button3;
        private Button button4;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column18;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column17;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column15;
    }
}
