using System;
using System.Windows.Forms;

namespace Project_HIT
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SchoolMain hit = new SchoolMain();

            RememberMe i = new RememberMe();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(hit));
        }
    }
}
