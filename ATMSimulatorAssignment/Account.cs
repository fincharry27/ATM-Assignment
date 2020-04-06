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


        static LoginScreen LDLogin;
        static ATMWindow LDWindow;
        public string acnumber;
        public string pinnumber;

        //Temp account numbers here
        //Todo:Swap from Hardcoded numbers to Arrays
        string AccountNumber1ACN = "111111";
        string AccountNumber1Pin = "111";
        string AccountNumber1Bal = "300";
        string AccountNumber2CAN = "222222";
        string AccountNumber2Pin = "2222";
        string AccountNumber2Bal = "750";
        string AccountNumber3ACN = "333333";
        string AccountNumber3Pin = "3333";
        string AccountNumber3Bal = "3000";

        public void AccountControl()
        {

            if (AccountNumber1ACN == acnumber && AccountNumber1Pin == pinnumber || AccountNumber2CAN == acnumber && AccountNumber2Pin == pinnumber|| AccountNumber3ACN == acnumber && AccountNumber3Pin == pinnumber)
            {
                //Add something here to store account number for ATM Windows
                acnumber = ATMSimulatorAssignment.Program.Debug;
                var newForm = new ATMWindow();
                newForm.Show();
            }
            else
            {
                MessageBox.Show("AccountNumber or Passowrd is Incoorect");
                var newForm = new LoginScreen();
                newForm.Show();
            }


        }

    }

}
