using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int year))
            {
                if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                {
                    textBox2.Text = $"{year} is a Leap Year";
                }
                else
                {
                    textBox2.Text = $"{year} is not a Leap Year";
                }
            }
            else
            {
                textBox2.Text = "Please enter a valid year";
            }
        }
    }
}
