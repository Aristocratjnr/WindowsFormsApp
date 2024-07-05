using System;
using System.Windows.Forms;
using ProfessionalWindowsFormsApp;

//This is the main entry point for the application.

namespace WindowsFormsApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
