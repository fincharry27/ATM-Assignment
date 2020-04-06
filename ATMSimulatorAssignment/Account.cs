using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ATMSimulatorAssignment
{
    public class Account
    {
        //Class variables
        private int accountNumber;
        private int pin;
        private int balance;
        private bool dataSafe;
        private Object threadLock = new Object();


        //Class constructor
        public Account(int accountNumber, int pin, int balance)
        {
            this.accountNumber = accountNumber;
            this.pin = pin;
            this.balance = balance;
            this.dataSafe = false;
        }

        //Getters and setters
        public int accNumber
        {
            get
            {
                return accountNumber;
            }
            set
            {
                accountNumber = value;
            }
        }

        public int accPin
        {
            get
            {
                return pin;
            }
            set
            {
                pin = value;
            }
        }

        public int accBalance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }

        public void setDatasafe(bool check)
        {
            dataSafe = check;
        }

        public bool getDataSafe() 
        {
            return dataSafe;
        }

        //Methods

        //Checks if pin entered by the user matches the account's pin
        public Boolean validatePin(int enteredPin) 
        {
            if (enteredPin == pin) 
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        //Withdraws the money from the users balance, locks the thread if datasafe is on
        public Boolean withdraw(int amount)
        {
            if (this.accBalance >= amount)
            {
                if (dataSafe)
                {
                    lock (threadLock)
                    {
                        Thread.Sleep(3000);
                        accBalance -= amount;
                    }
                }
                else
                {
                    Thread.Sleep(3000);
                    accBalance -= amount;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
