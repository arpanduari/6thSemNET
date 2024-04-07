using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace linear_search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private int LinearSearch(string[] array, int searchElement)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (int.Parse(array[i]) == searchElement)
                {
                    return i;
                }
            }
            return -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] elements = textBox1.Text.Split(',');
            int searchElement = int.Parse(textBox2.Text);
            int foundIndex = LinearSearch(elements, searchElement);

            if (foundIndex != -1)
            {
                textBox3.Text = $"The number {searchElement} is found at index {foundIndex}.";
            }
            else
            {
                textBox3.Text = $"The number {searchElement} is not found at index {foundIndex}";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Text = string.Empty;
        }
    }
}
