using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProfessionalWindowsFormsApp
{
    public partial class DrawingForm : Form
    {
        // Variables for the drawing canvas
        private bool isDrawing = false;
        private Point lastPoint = Point.Empty;

        public DrawingForm()
        {
            InitializeComponent();
        }

        private void pnlCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            lastPoint = e.Location;
        }

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

        private void pnlCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }
    }
}
