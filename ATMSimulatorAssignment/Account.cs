using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ATMSimulatorAssignment
{
    public class Account
    {
        //Class variables
        public int acnumber { get; set; }
        public int pinnumber { get; set; }
        static LoginScreen LDLogin;
        static ATMWindow LDWindow;

        //Temp account numbers here
        //Todo:Swap from Hardcoded numbers to normal.
        int AccountNumber1ACN = 111111;
        int AccountNumber1Pin = 111;
        int AccountNumber1Bal = 300;
        int AccountNumber2CAN = 222222;
        int AccountNumber2Pin = 2222;
        int AccountNumber2Bal = 750;
        int AccountNumber3ACN = 333333;
        int AccountNumber3Pin = 3333;
        int AccountNumber3Bal = 3000;

        public void AccountControl()
        {
            ATMSimulatorAssignment.LoginScreen.GetfirstVal = acnumber;
            ATMSimulatorAssignment.LoginScreen.GetsecondVal = pinnumber;

            if (AccountNumber1ACN == acnumber && AccountNumber1Pin == pinnumber || AccountNumber2CAN == acnumber && AccountNumber2Pin == pinnumber|| AccountNumber3ACN == acnumber && AccountNumber3Pin == pinnumber)
            {
                //Add something here to store account number
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                acnumber = ATMSimulatorAssignment.Program.Debug;
                LDWindow = new ATMWindow();
                Application.Run(LDWindow);
            }
            else
            {
             Application.EnableVisualStyles();
             Application.SetCompatibleTextRenderingDefault(false);
             LDLogin = new LoginScreen();
             Application.Run(LDLogin);
            }


        }

    }

}
