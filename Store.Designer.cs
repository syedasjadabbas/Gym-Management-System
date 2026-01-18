namespace GymManagement
{
    partial class Store
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
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.Location = new Point(0, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(1716, 1065);
            panel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 224, 192);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Maiandra GD", 10.8F);
            button1.ForeColor = Color.FromArgb(64, 0, 0);
            button1.Location = new Point(3, 16);
            button1.Name = "button1";
            button1.Size = new Size(191, 38);
            button1.TabIndex = 7;
            button1.Text = "Make a purchase";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 224, 192);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Maiandra GD", 10.8F);
            button2.ForeColor = Color.FromArgb(64, 0, 0);
            button2.Location = new Point(200, 16);
            button2.Name = "button2";
            button2.Size = new Size(191, 38);
            button2.TabIndex = 8;
            button2.Text = "Sales and Stock";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // Store
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(button2);
            Name = "Store";
            Size = new Size(1717, 1117);
            Load += Sales_Load;
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button button1;
        private Button button2;
    }
}
