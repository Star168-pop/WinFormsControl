namespace WinFormsControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            MessageBox.Show("Hello,User", "Frist Message");

            //MessageBox.Show("Hello,User", "Second Message",
            //    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("ต้องหารปิดจริงหรือไม่", "แน่ใจนะ",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true; //ยกเลิกคำสั้่งเปิดฟอร์ม
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Random rn = new Random();
            int r = rn.Next(0, 255);
            int g = rn.Next(0, 255);
            int b = rn.Next(0, 255);

            this.BackColor = Color.FromArgb(r, g, b);
            this.Text = r.ToString() + "," + g.ToString() + "," + b.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.HotPink;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.HotPink;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.HotPink;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            if (label1.Text == "มหาวิทยาลัยราชภัฏอุดรธานี")
            {
                label1.Text = "Udonthani Rajabhat University";
            }
            else
            {
                label1.Text = "มหาวิทยาลัยราชภัฏอุดรธานี";
            }
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "Udonthani Rajabhat University";
            label1.BackColor = Color.Salmon;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.GreenYellow;
            label1.Text = "มหาวิทยาลัยราชภัฏอุดรธานี";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            Random rn = new Random();
            int r = rn.Next(0, 255);
            int g = rn.Next(0, 255);
            int b = rn.Next(0, 255);
            label1.ForeColor = Color.FromArgb(r, g, b);
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            //textBox1.Text = "";
            //textBox1.Text = string.Empty;
            textBox1.Text = null;

            //ใช้แบบไหนก็ได้
        }
    }
}
