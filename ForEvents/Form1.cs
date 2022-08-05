namespace ForEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += MyCustomHandeller;
            button1.Click += openform2;
            textBox1.LostFocus += textlostfocus;
            textBox1.LostFocus += checkvalidemal;
        }

        private void openform2(object? sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
        }

        private void MyCustomHandeller(object? sender, EventArgs e)
        {
            MessageBox.Show("using my custom handeller to handle button1.click");
            
        }

        private void checkvalidemal(object? sender, EventArgs e)
        {
            bool isvalidemail = textBox1.Text.ToLower().Contains("@kpmg.com");
            if (isvalidemail)
            {
                textBox1.BackColor = Color.Green;
                textBox1.ForeColor = Color.Blue;

            }

            else
            {
                textBox1.BackColor = Color.Red;
                textBox1.ForeColor = Color.Yellow;
                MessageBox.Show("invalid email");
            }
        }

        private void textlostfocus(object? sender, EventArgs e)
        {
            textBox1.Text = "kpmg-" + textBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HANDELLING BUTTON1.CLICK");
        }
    }
}