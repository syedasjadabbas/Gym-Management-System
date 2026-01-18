namespace GymManagement
{
    public partial class Starting_Screen : Form
    {
        string filepath = "";
        public Starting_Screen()
        {
            InitializeComponent();
            Helper.SetRoundedButton(button1, 40);
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && filepath != "")
            {
                byte[] image = File.ReadAllBytes(filepath);
                Form2 form = new(textBox1.Text, image);
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                label5.Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "JPEG Files|*.jpeg;*.jpg|PNG Files|*.png|All Files|*.*";
            openFileDialog.Title = "Select an Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog.FileName;
                pictureBox1.ImageLocation = filepath;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Restore restore = new Restore();
            this.Hide();
            restore.ShowDialog();
            this.Close();
        }
    }
}
