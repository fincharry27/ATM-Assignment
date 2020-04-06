using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSimulatorAssignment
{
    public class Bank
    {
        //fields
        public Account[] accountList = new Account[3];

        //methods
        //Initialises accounts
        public Bank()
        {
            accountList[0] = new Account(111111, 1111, 300);
            accountList[0] = new Account(222222, 2222, 750);
            accountList[0] = new Account(333333, 3333, 3000);
        }

        //returns list of accounts
        public Account[] getAccountList()
        {
            return accountList;
        }
    }
}
