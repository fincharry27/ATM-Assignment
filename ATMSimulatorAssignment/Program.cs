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
     *   Class programm contains an array of account objects and a singel ATM object  
     * 
     */
    class Program
    {
        private Account[] ac = new Account[3];
        private ATM atm;
        public Thread ATM1_t, ATM2_t;
        static MainWindow LDDebugMenu;
        static LoginScreen LDLogin;
        static ATMWindow LDWindow;
        static Account LDaccount = new Account();
        public string General = null;
        // Debug is set to 1 if D
        public static int Debug = 0;

        /*
         * This fucntions initilises the 3 accounts 
         * and instanciates the ATM class passing a referance to the account information
         * 
         */

        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LDDebugMenu = new MainWindow();
            Application.Run(LDDebugMenu);
        }

        /*
  *   The Account class encapusulates all features of a simple bank account
  */
        class Account
        {
            //the attributes for the account
            private int balance;
            private int pin;
            private int accountNum;

            // a constructor that takes initial values for each of the attributes (balance, pin, accountNumber)
            public Account(int balance, int pin, int accountNum)
            {
                this.balance = balance;
                this.pin = pin;
                this.accountNum = accountNum;
            }

            public Account()
            {
            }

            //getter and setter functions for balance
            public int getBalance()
            {
                return balance;
            }
            public void setBalance(int newBalance)
            {
                this.balance = newBalance;
            }

            /*
             *   This funciton allows us to decrement the balance of an account
             *   it perfomes a simple check to ensure the balance is greater tha
             *   the amount being debeted
             *   
             *   reurns:
             *   true if the transactions if possible
             *   false if there are insufficent funds in the account
             */
            public Boolean decrementBalance(int amount)
            {
                if (this.balance > amount)
                {
                    balance -= amount;
                    return true;
                }
                else
                {
                    return true;
                }
            }

            /*
             * This funciton check the account pin against the argument passed to it
             *
             * returns:
             * true if they match
             * false if they do not
             */
            public Boolean checkPin(int pinEntered)
            {
                if (pinEntered == pin)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public int getAccountNum()
            {
                return accountNum;
            }

        }

        /* 
         *      This is out main ATM class that preforms the actions outlined in the assigment hand out
         *      
         *      the constutor contains the main funcitonality.
         */
        class ATM
        {
            //local referance to the array of accounts
            private Account[] ac;

            //this is a referance to the account that is being used
            private Account activeAccount = null;

            // the atm constructor takes an array of account objects as a referance
            public ATM(Account[] ac)
            {
                TextBox a = Application.OpenForms["LoginScreen"].Controls["LogInTextBox"] as TextBox;

                TextBox b = Application.OpenForms["LoginScreen"].Controls["LogInTextBox"] as TextBox;



                this.ac = ac;

                if (activeAccount == this.findAccount())
                {
                    if (activeAccount.checkPin(this.promptForPin()))
                    {

                        LDWindow = new ATMWindow(); 
                        Application.Run(LDWindow);
                    }
                    else
                    {
                        MessageBox.Show("Account/Password Incorrect");
                    }
                
                }

                else
                {
                    MessageBox.Show("Account/Password Incorrect");
                }


                // an infanite loop to keep the flow of controll going on and on
                while (true)
                {

                    //ask for account number and store result in acctiveAccount (null if no match found)
                    activeAccount = this.findAccount();


                    if (activeAccount != null)
                    {
                        //if the account is found check the pin 
                        if (activeAccount.checkPin(this.promptForPin()))
                        {
                            //if the pin is a match give the options to do stuff to the account (take money out, view balance, exit)
                            LDWindow = new ATMWindow();
                            Application.Run(LDWindow);
                        }
                    }
                    else
                    {   //if the account number entered is not found let the user know!
                        Console.WriteLine("no matching account found.");
                    }

                    //wipes all text from the console
                    //Console.Clear();
                }
            }

            /*
         *    this method promts for the input of an account number
         *    the string input is then converted to an int
         *    a for loop is used to check the enterd account number
         *    against those held in the account array
         *    if a match is found a referance to the match is returned
         *    if the for loop completest with no match we return null
         * 
         */
            private Account findAccount()
            {
                Console.WriteLine("enter your account number..");

                int input = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < this.ac.Length; i++)
                {
                    if (ac[i].getAccountNum() == input)
                    {
                        return ac[i];
                    }
                }

                return null;
            }
            /*
             * 
             *  this jsut promt the use to enter a pin number
             *  
             * returns the string entered converted to an int
             * 
             */
            private int promptForPin()
            {
                Console.WriteLine("enter pin:");
                String str = Console.ReadLine();
                int pinNumEntered = Convert.ToInt32(str);
                return pinNumEntered;
            }

        }
    }
}


