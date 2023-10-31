using System.Data;
using System.Windows.Forms.VisualStyles;

namespace Calculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            inputTextBox.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            inputTextBox.Text += "8";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputTextBox.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            inputTextBox.Text += "*";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            inputTextBox.Text += "+";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            inputTextBox.TextAlign = (HorizontalAlignment)VerticalAlignment.Center;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            inputTextBox.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inputTextBox.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inputTextBox.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            inputTextBox.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            inputTextBox.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            inputTextBox.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            inputTextBox.Text += "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            inputTextBox.Text += "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            inputTextBox.Text += "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new DataTable().Compute(inputTextBox.Text, null);
                inputTextBox.Text = result.ToString();
            }
            catch
            {
                inputTextBox.Text = "Error occurred";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            inputTextBox.Clear();
        }
    }
}