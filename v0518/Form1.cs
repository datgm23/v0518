namespace v0518
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Top = label1.Top - 10;
            label1.Text = "(°ω °)";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Left = label1.Left - 10;
            label1.Text = "(・ω・#)";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Left = label1.Left + 10;
            label1.Text = "(#・ω・)";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Top = label1.Top + 10;
            label1.Text = "( .  . )";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(label1.Top.ToString());
            MessageBox.Show($"label1.Top={label1.Top}");
        }
    }
}