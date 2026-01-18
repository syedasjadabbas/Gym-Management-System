namespace GymManagement
{
    partial class Add_Trainer
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
            label2 = new Label();
            splitContainer1 = new SplitContainer();
            label3 = new Label();
            label1 = new Label();
            label7 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Maiandra GD", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(45, 19);
            label2.Name = "label2";
            label2.Size = new Size(198, 24);
            label2.TabIndex = 30;
            label2.Text = "Add a new Trainer:";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(45, 59);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(64, 0, 0);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(label6);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.PeachPuff;
            splitContainer1.Panel2.Controls.Add(textBox4);
            splitContainer1.Panel2.Controls.Add(textBox1);
            splitContainer1.Panel2.Controls.Add(textBox2);
            splitContainer1.Panel2.Controls.Add(textBox3);
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Size = new Size(649, 245);
            splitContainer1.SplitterDistance = 234;
            splitContainer1.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Maiandra GD", 10.2F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(31, 68);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 18;
            label3.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Maiandra GD", 10.2F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(31, 27);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 7;
            label1.Text = "First Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Maiandra GD", 10.2F);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(31, 206);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 17;
            label7.Text = "Salary";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Maiandra GD", 10.2F);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(31, 115);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 15;
            label6.Text = "Address";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(32, 203);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(32, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(32, 112);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(340, 74);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(32, 65);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Coral;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Maiandra GD", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(64, 0, 0);
            button1.Location = new Point(265, 199);
            button1.Name = "button1";
            button1.Size = new Size(116, 33);
            button1.TabIndex = 4;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Add_Trainer
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(762, 353);
            Controls.Add(label2);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Add_Trainer";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_Trainer";
            Load += Add_Trainer_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private SplitContainer splitContainer1;
        private Label label3;
        private Label label1;
        private Label label7;
        private Label label6;
        private TextBox textBox4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
    }
}