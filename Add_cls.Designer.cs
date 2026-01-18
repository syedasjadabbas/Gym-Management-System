namespace GymManagement
{
    partial class Add_cls
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            label7 = new Label();
            label6 = new Label();
            comboBox2 = new ComboBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(86, 97);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(64, 0, 0);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(label6);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.PeachPuff;
            splitContainer1.Panel2.Controls.Add(comboBox2);
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Panel2.Controls.Add(comboBox1);
            splitContainer1.Panel2.Controls.Add(dateTimePicker3);
            splitContainer1.Panel2.Controls.Add(dateTimePicker2);
            splitContainer1.Panel2.Controls.Add(dateTimePicker1);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(493, 288);
            splitContainer1.SplitterDistance = 177;
            splitContainer1.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Maiandra GD", 10.2F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(31, 199);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 19;
            label2.Text = "Trainer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Maiandra GD", 10.2F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(31, 68);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 18;
            label3.Text = "Starting Time";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Maiandra GD", 10.2F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(31, 27);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 7;
            label1.Text = "Class Type";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Maiandra GD", 10.2F);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(31, 152);
            label7.Name = "label7";
            label7.Size = new Size(43, 20);
            label7.TabIndex = 17;
            label7.Text = "Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Maiandra GD", 10.2F);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(31, 110);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 15;
            label6.Text = "Ending Time";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(56, 201);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(177, 28);
            comboBox2.TabIndex = 10;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Coral;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Maiandra GD", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(64, 0, 0);
            button1.Location = new Point(185, 244);
            button1.Name = "button1";
            button1.Size = new Size(116, 33);
            button1.TabIndex = 4;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(56, 24);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(177, 28);
            comboBox1.TabIndex = 9;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(56, 152);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(177, 27);
            dateTimePicker3.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(56, 110);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(177, 27);
            dateTimePicker2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(56, 68);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(177, 27);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Maiandra GD", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 0, 0);
            label4.Location = new Point(50, 49);
            label4.Name = "label4";
            label4.Size = new Size(141, 36);
            label4.TabIndex = 33;
            label4.Text = "Add Class";
            // 
            // Add_cls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 417);
            Controls.Add(label4);
            Controls.Add(splitContainer1);
            Name = "Add_cls";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_cls";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label3;
        private Label label1;
        private Label label7;
        private Label label6;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker3;
        private Label label2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label4;
    }
}