using System;
using System.Windows.Forms;

namespace NumberDisplayApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumberInput.Text, out int number) && number > 0)
            {
                lstNumbers.Items.Clear();
                for (int i = 1; i <= number; i++)
                {
                    lstNumbers.Items.Add(i);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid positive integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstNumbers.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
