using System;
using System.Windows.Forms;
using System.Threading;

namespace ATMSimulatorAssignment
{
    static class Program
    {
        private static Bank Bank1;
        static Account[] activeAccountList;
        static Thread ATMWindowThread;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Bank1 = new Bank();
            activeAccountList = Bank1.getAccountList();

            Application.Run(new MainWindow(activeAccountList));
        }

        public static void openATM() 
        {
            ATMWindowThread = new Thread(LoginFormProcess);
            ATMWindowThread.Start();
        }

        private static void LoginFormProcess()
        {
            //create log in screen constructor
            Application.Run(new LoginScreen(activeAccountList));
        }
    }
}
