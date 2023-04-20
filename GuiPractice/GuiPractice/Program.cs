using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiPractice
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //output Show
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            //Application is static  
            //Form1 will run first
            Application.Run(new frmSignUp());
        }
    }
}
