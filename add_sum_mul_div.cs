using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_operations
{
    public partial class Form1 : Form
    {
        int n1, n2;
        int sum, subtract, mul, div;

        private void multiplication_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToInt32(box1.Text);
            n2 = Convert.ToInt32(box2.Text);
            mul = n1 * n2;
            answer.Text = mul.ToString();
        }

        private void divition_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToInt32(box1.Text);
            n2 = Convert.ToInt32(box2.Text);
            div = n1 / n2;
            answer.Text = div.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            box1.Clear();
            box2.Clear();
            answer.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToInt32(box1.Text);
            n2 = Convert.ToInt32(box2.Text);
            sum = n1 + n2;
            answer.Text = sum.ToString();
        }

        private void sub_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToInt32(box1.Text);
            n2 = Convert.ToInt32(box2.Text);
            subtract = n1 - n2;
            answer.Text = subtract.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
