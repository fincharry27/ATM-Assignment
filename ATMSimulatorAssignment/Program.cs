using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ATMSimulatorAssignment
{
    /*
     *   This is the root of program and the entry point
     * 
     * 
     */
    class Program
    {
        private Account[] ac = new Account[3];
        public Thread ATM1_t, ATM2_t; //Todo: Start threads once LogIn screen is working
        static MainWindow LDDebugMenu;
        static LoginScreen LDLogin;
        static ATMWindow LDWindow;
        static Account LDaccount = new Account();
        public string General = null;
        public static string Debug = "0";

        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LDDebugMenu = new MainWindow();
            Application.Run(LDDebugMenu);
        }

    }
}


