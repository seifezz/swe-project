using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flight_project
{

    static class Program
    {

        public static string globaleEmail = "";
        public static bool Authanticated = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new signinform());

            if (Authanticated)
            {
                Application.Run(new UserForm());
            }
            else
            {
                MessageBox.Show("Faild to load Programe..!");
            }
        }
    }
}
