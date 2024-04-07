using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int start) && int.TryParse(textBox2.Text, out int end))
            {
                if (start <= end)
                {
                    List<int> primes = CalculatePrimesInRange(start, end);
                    textBox3.Text = string.Join(Environment.NewLine, primes);
                }
                else
                {
                    MessageBox.Show("End number should be greater than or equal to start number.");
                }
            }
            else
            {
                MessageBox.Show("Please enter valid integer numbers for range.");
            }
        }

        private List<int> CalculatePrimesInRange(int start, int end)
        {
            List<int> primes = new List<int>();

            for (int number = start; number <= end; number++)
            {
                if (IsPrime(number))
                {
                    primes.Add(number);
                }
            }

            return primes;
        }

        private bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }
    }
}
