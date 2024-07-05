using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProfessionalWindowsFormsApp
{
    // This class contains the event handlers for the form
    public partial class Form1 : Form
    {
        // Variables for the drawing canvas
        private bool isDrawing = false;
        private Point lastPoint = Point.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for the login button
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            MessageBox.Show($"Username: {username}\nPassword: {password}", "Login Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Event handler for the save button in the address book
        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            MessageBox.Show($"Name: {name}\nEmail: {email}\nPhone: {phone}", "Address Book Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Event handler for mouse down event on the canvas
        private void pnlCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            lastPoint = e.Location;
        }

        // Event handler for mouse move event on the canvas
        private void pnlCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Graphics g = pnlCanvas.CreateGraphics())
                {
                    g.DrawLine(Pens.Black, lastPoint, e.Location);
                }
                lastPoint = e.Location;
            }
        }

        // Event handler for mouse up event on the canvas
        private void pnlCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }
    }
}
