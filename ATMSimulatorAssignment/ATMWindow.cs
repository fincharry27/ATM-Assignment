using System;
using System.Windows.Forms;

namespace ATMSimulatorAssignment
{
    public partial class ATMWindow : Form 
    {
        private bool systemExit = false;
        private bool mainMenuDisplaying = true;
        private bool withdrawMenuDisplaying = true;
        private bool balanceScreenDisplaying = true;
        private bool actionComplete = false;

        Account activeAccount;

        public ATMWindow(Account activeAccount)
        {
            InitializeComponent();
            this.activeAccount = activeAccount;
            displayMainMenu();
        }

        private void ATMWindow_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MainDisplayBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InputTextBox.Text += '1';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InputTextBox.Text += '2';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InputTextBox.Text += '3';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InputTextBox.Text += '4';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InputTextBox.Text += '5';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InputTextBox.Text += '6';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            InputTextBox.Text += '7';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            InputTextBox.Text += '8';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            InputTextBox.Text += '9';
        }

        private void button0_Click(object sender, EventArgs e)
        {
            InputTextBox.Text += '0';
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            InputTextBox.Text = "";
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (systemExit == false) 
            {
                displayMainMenu();
                int userInput = enteredValue();

                if (mainMenuDisplaying == true && actionComplete == true)
                {
                    //reset as action will have been comopleted
                    actionComplete = false;
                    InputTextBox.Text = "";
                    displayMainMenu();
                }
                else if (mainMenuDisplaying == true && actionComplete == false)
                {
                    if (userInput == 1)
                    {
                        //withdraw
                        mainMenuDisplaying = false;
                        withdrawMenuDisplaying = true;
                        displayWithdrawMenu();
                    }
                    else if (userInput == 2)
                    {
                        //display balance
                        mainMenuDisplaying = false;
                        balanceScreenDisplaying = true;
                        displayBalanceScreen();
                        actionComplete = true;
                        mainMenuDisplaying = true;
                    }
                    else if (userInput == 3)
                    {
                        //log out
                        LogOut();
                    }
                    else
                    {
                        //invalid selction
                        MessageBox.Show("Please enter a valid choice.");
                    }

                }
                else if (withdrawMenuDisplaying == true && actionComplete == false) 
                {
                    int amount = withdrawalAmount(userInput);
                    if (amount != 0)
                    {
                        activeAccount.withdraw(amount);
                        displayPostWithdrawScreen(amount);
                        actionComplete = true;
                        mainMenuDisplaying = true;
                    }
                    else
                    {
                        MessageBox.Show("You have chosen an incorrect number.");
                        actionComplete = true;
                        mainMenuDisplaying = true;
                    }
                }
            }
        }

        public int withdrawalAmount(int userInput) 
        {
            if (userInput == 1)
            {
                return 10;
            }
            else if (userInput == 2)
            {
                return 20;
            }
            else if (userInput == 3)
            {
                return 50;
            }
            else if (userInput == 4)
            {
                return 100;
            }
            else if (userInput == 5)
            {
                return 500;
            }
            else 
            {
                return 0;
            }
        }

        public int enteredValue() 
        {
            int enteredValue;

            if (InputTextBox.Text == "")
            {
                enteredValue = 0;
            }
            else 
            {
                enteredValue = Convert.ToInt32(InputTextBox.Text);
                InputTextBox.Text = "";
            }

            return enteredValue;
        }

        private void displayMainMenu() 
        {
            MainDisplayBox.Text = "Welcome to the online ATM\r\n\r\n"
                + "Please select from the following options:\r\n"
                + "1. Withdraw money\r\n"
                + "2. Check Balance\r\n"
                + "3. Log out\r\n\r\n"
                + "Please enter a number in range 1-3";
        }

        private void displayWithdrawMenu()
        {
            MainDisplayBox.Text = "Please select amount to withdraw:\r\n\r\n"
                + "1. £10\r\n"
                + "2. £20\r\n"
                + "3. £50\r\n"
                + "4. £100\r\n"
                + "5. £500\r\n\r\n"
                + "Please enter a number in range 1-3";
        }

        public void displayPostWithdrawScreen(int withdrawnMoney) 
        {
            MainDisplayBox.Text = "You have successfully withdrawn:\r\n\r\n"
                + "£" + withdrawnMoney + ".00\r\n"
                + "from your account. Your new balance is:\r\n"
                + "£" + activeAccount.accBalance + ".00\r\n"
                + "Press enter to return";
        }

        private void displayBalanceScreen() 
        {
            MainDisplayBox.Text = "Your availaible balance is:\r\n\r\n"
                + "£" + activeAccount.accBalance + ".00\r\n\r\n"
                +"Press enter to return";
        }
        public void LogOut()
        {
            MainDisplayBox.Text = "Logging out of online ATM\r\n";
            systemExit = true;
            this.Close();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            LogOut();
        }

    }
}
