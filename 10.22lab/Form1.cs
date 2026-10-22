namespace _10._22lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox1.Text += "=";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "1";
            else textBox1.Text += "1";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Sqrt(double.Parse(textBox1.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}
