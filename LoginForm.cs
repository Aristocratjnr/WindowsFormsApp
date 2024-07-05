using System;
using System.Windows.Forms;

namespace ProfessionalWindowsFormsApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Validate login (you can add more complex validation here)
            if (username == "aristo" && password == "junior1")
            {
                this.Hide();
                AddressBookForm addressBookForm = new AddressBookForm();
                addressBookForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
