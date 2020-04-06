using System;
using System.Windows.Forms;

namespace ATMSimulatorAssignment
{
    public partial class LoginScreen : Form
    {
        public Account[] accountList;

        public LoginScreen(Account[] accountList)
        {
            InitializeComponent();
            this.accountList = accountList;
        }

        public void show() 
        {
            this.show();
        }

        private void LogInTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            bool successfulLogInFlag = false;

            for (int i = 0; i < 3; i++) 
            {
                if (LogInTextBox.Text == accountList[i].accNumber.ToString()) 
                {
                    //account number matches
                    //check pin
                    if (PasswordTextBox.Text == accountList[i].accPin.ToString()) 
                    {
                        //successfull log in
                        successfulLogInFlag = true;
                        //create new atm
                        ATMWindow ClientATMWindow = new ATMWindow(accountList[i]);
                        ClientATMWindow.Visible = true;
                        this.Hide();
                    }
                }
            }
            if (successfulLogInFlag == false) 
            {
                MessageBox.Show("No account found matching provided info.");
            }
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            LogInTextBox.MaxLength = 6;
            PasswordTextBox.MaxLength = 4;
        }
    }
}
