namespace GymManagement
{
    partial class First_page
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel4 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button5 = new Button();
            button3 = new Button();
            panel2 = new Panel();
            button4 = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(10, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "ImageLogo";
            // 
            // label1
            // 
            label1.Font = new Font("Maiandra GD", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.PeachPuff;
            label1.Location = new Point(3, 282);
            label1.Name = "label1";
            label1.Size = new Size(276, 164);
            label1.TabIndex = 1;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            flowLayoutPanel1.BackColor = Color.FromArgb(64, 0, 0);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Font = new Font("Maiandra GD", 16.2F);
            flowLayoutPanel1.Location = new Point(-1, -3);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(279, 1029);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox1);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(276, 276);
            panel4.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 0, 0);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Popup;
            flowLayoutPanel1.SetFlowBreak(button1, true);
            button1.Font = new Font("Maiandra GD", 16.2F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 466);
            button1.Margin = new Padding(0, 20, 0, 0);
            button1.Name = "button1";
            button1.Size = new Size(279, 65);
            button1.TabIndex = 2;
            button1.Text = "DashBoard";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 0, 0);
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Maiandra GD", 16.2F);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(0, 551);
            button2.Margin = new Padding(0, 20, 0, 0);
            button2.Name = "button2";
            button2.Size = new Size(279, 65);
            button2.TabIndex = 3;
            button2.Text = "Members\r\n";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(64, 0, 0);
            button5.BackgroundImageLayout = ImageLayout.None;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Maiandra GD", 16.2F);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(0, 636);
            button5.Margin = new Padding(0, 20, 0, 0);
            button5.Name = "button5";
            button5.Size = new Size(279, 65);
            button5.TabIndex = 6;
            button5.Text = "Payments";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 0, 0);
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Maiandra GD", 16.2F);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(0, 721);
            button3.Margin = new Padding(0, 20, 0, 0);
            button3.Name = "button3";
            button3.Size = new Size(279, 65);
            button3.TabIndex = 7;
            button3.Text = "Store";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // panel2
            // 
            panel2.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(3, 789);
            panel2.Name = "panel2";
            panel2.Size = new Size(276, 96);
            panel2.TabIndex = 9;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(64, 0, 0);
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Maiandra GD", 16.2F);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(0, 908);
            button4.Margin = new Padding(0, 20, 0, 0);
            button4.Name = "button4";
            button4.Size = new Size(279, 65);
            button4.TabIndex = 5;
            button4.Text = "Settings";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Linen;
            panel1.Location = new Point(278, -2);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1721, 1117);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // First_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1896, 1027);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MinimumSize = new Size(1918, 1078);
            Name = "First_page";
            Load += First_page_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
    }
}