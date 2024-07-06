using System;
using System.Windows.Forms;

namespace ProfessionalWindowsFormsApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
             // Uncomment the form you want to run
            // Application.Run(new AddressBookForm());
            // Application.Run(new DrawingForm());
           
            Application.Run(new LoginForm());
        }
    }
}
