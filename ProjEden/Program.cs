using System;
using System.Windows.Forms;

namespace FinalProjEden_and_Ofir
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new LogIn());
            }
            catch (Exception)
            {
                MessageBox.Show("Major error has occured!", "Error");
            }
        }
    }
}
