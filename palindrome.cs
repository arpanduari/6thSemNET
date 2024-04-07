using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palindrome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int number))
            {
                bool isPalindrome = IsPalindrome(number);
                if (isPalindrome)
                {
                    textBox2.Text = "The number is a palindrome number.";
                }
                else
                {
                    textBox2.Text = "The number is not a palindrome number.";
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.");
            }
        }

        private bool IsPalindrome(int number)
        {
            int reversedNumber = 0;
            int originalNumber = number;

            while (number > 0)
            {
                int remainder = number % 10;
                reversedNumber = reversedNumber * 10 + remainder;
                number /= 10;
            }

            return originalNumber == reversedNumber;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
