using System;
using System.Windows.Forms;

namespace ProfessionalWindowsFormsApp
{
    public partial class AddressBookForm : Form
    {
        public AddressBookForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;

            MessageBox.Show($"Name: {name}\nEmail: {email}\nPhone: {phone}", "Address Book Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            DrawingForm drawingForm = new DrawingForm();
            drawingForm.Show();
        }
    }
}
