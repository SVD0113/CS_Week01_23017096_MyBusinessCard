namespace _2_1
{
    public partial class Form1 : Form
    {
        Image originalPhoto;
        bool isChanged = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            originalPhoto = pictureBox1.Image;
            this.ActiveControl = label4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("https://github.com/SVD0113") { UseShellExecute = true });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            this.BackColor = Color.FromArgb(rd.Next(256), rd.Next(256), rd.Next(256));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isChanged == false)
            {
                pictureBox1.Image = Properties.Resources.백지헌;
                isChanged = true;
            }
            else
            {
                pictureBox1.Image = originalPhoto;
                isChanged = false;
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void label4_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void button3_MouseLeave(object sender, EventArgs e) { }
        private void False(object sender, EventArgs e) { }
    }
}