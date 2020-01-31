using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkComicSuiteTest
{
    static class Program
    {
        static public ConnectForm connectForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            connectForm = new ConnectForm();
            Application.Run(connectForm);
        }

        static public void showConnectForm()
        {
            Program.connectForm.BeginInvoke((MethodInvoker)delegate () {
                Program.connectForm.Show();
            });
        }

    }
}
