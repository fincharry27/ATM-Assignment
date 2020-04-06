using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMSimulatorAssignment
{

    public partial class LoginScreen : Form
    {
        public static int GetfirstVal { get; internal set; }
        public static int GetsecondVal { get; internal set; }

        public LoginScreen()
        { 
            InitializeComponent();
        }

        private void LogInTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            //ATM a = new ATM();
            //.someMethod();
            Account account = new Account();
            account.acnumber = LogInTextBox.Text;
            account.pinnumber = PasswordTextBox.Text;
            this.Hide();
            account.AccountControl();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
