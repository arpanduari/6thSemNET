using System;
using System.Text;
using System.Windows.Forms;

namespace fibonacci_series
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int term))
            {
                if (term < 1)
                {
                    MessageBox.Show("Please enter a positive integer.");
                    return;
                }

                string series = GenerateFibonacciSeries(term);
                textBox3.Text = series;
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.");
            }
        }

        private string GenerateFibonacciSeries(int term)
        {
            StringBuilder series = new StringBuilder();
            int a = 0, b = 1;

            series.AppendLine(a.ToString());
            if (term >= 2)
                series.AppendLine(b.ToString());

            for (int i = 3; i <= term; i++)
            {
                int c = a + b;
                series.AppendLine(c.ToString());
                a = b;
                b = c;
            }

            return series.ToString();
        }
    }
}
