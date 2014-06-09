using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GSB.App.Views;

namespace GSB.App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var login = new Login();
            Application.Run(login);
        }
    }
}
