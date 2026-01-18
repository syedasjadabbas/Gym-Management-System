namespace GymManagement
{
    partial class Form2
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
            label1 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            splitContainer1 = new SplitContainer();
            label6 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Maiandra GD", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.PeachPuff;
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(33, 216);
            label1.Name = "label1";
            label1.Size = new Size(118, 45);
            label1.TabIndex = 1;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.AcceptsTab = true;
            textBox2.BackColor = SystemColors.ButtonHighlight;
            textBox2.ForeColor = SystemColors.WindowText;
            textBox2.Location = new Point(101, 155);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.ShortcutsEnabled = false;
            textBox2.Size = new Size(200, 27);
            textBox2.TabIndex = 2;
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Maiandra GD", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(21, 88);
            label3.Name = "label3";
            label3.Size = new Size(174, 64);
            label3.TabIndex = 4;
            label3.Text = "Create  a Password:";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Coral;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Maiandra GD", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(248, 279);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(117, 41);
            button1.TabIndex = 5;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Coral;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Maiandra GD", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(36, 279);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(84, 42);
            button2.TabIndex = 6;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(33, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(101, 185);
            label2.Name = "label2";
            label2.Size = new Size(200, 20);
            label2.TabIndex = 8;
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.Click += label2_Click_1;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(43, 67);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(64, 0, 0);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.PeachPuff;
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(textBox1);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(button2);
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Panel2.Controls.Add(textBox2);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(685, 347);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Maiandra GD", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(21, 203);
            label6.Name = "label6";
            label6.Size = new Size(205, 27);
            label6.TabIndex = 12;
            label6.Text = "Enter Server Name:";
            // 
            // textBox1
            // 
            textBox1.AcceptsTab = true;
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.Font = new Font("Maiandra GD", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(101, 236);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.ShortcutsEnabled = false;
            textBox1.Size = new Size(200, 25);
            textBox1.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Maiandra GD", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 0, 0);
            label4.Location = new Point(21, 24);
            label4.Name = "label4";
            label4.Size = new Size(191, 45);
            label4.TabIndex = 9;
            label4.Text = "Welcome ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Maiandra GD", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(12, 19);
            label5.Name = "label5";
            label5.Size = new Size(152, 45);
            label5.TabIndex = 10;
            label5.Text = "SignUp:";
            label5.Click += label5_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(785, 473);
            Controls.Add(label5);
            Controls.Add(splitContainer1);
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login/Sign up";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label label1;
        private TextBox textBox2;
        private Label label3;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label2;
        private SplitContainer splitContainer1;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
    }
}