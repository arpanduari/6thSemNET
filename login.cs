using System;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtpassword.Text;

            if (IsValidLogin(username, password))
            {
                OpenMainForm();
            }
            else
            {
                ShowInvalidLoginMessage();
                ClearFields();
            }
        }

        private bool IsValidLogin(string username, string password)
        {
            // Replace this with your actual authentication logic
            return (username == "tusar" && password == "1234");
        }

        private void OpenMainForm()
        {
            Form2 mainForm = new Form2();
            mainForm.Show();
            this.Hide();
        }

        private void ShowInvalidLoginMessage()
        {
            MessageBox.Show("The username or password you entered is incorrect. Please try again.", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ClearFields()
        {
            txtUserName.Clear();
            txtpassword.Clear();
            txtUserName.Focus();
        }

        private void labelClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
