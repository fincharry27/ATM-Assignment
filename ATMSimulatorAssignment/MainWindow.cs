using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMSimulatorAssignment
{
    public partial class MainWindow : Form
    {
        private Thread aTM1_t;

        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(Thread aTM1_t)
        {
            this.aTM1_t = aTM1_t;
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DataSafeCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            if (Program.Debug == 0)
            {
                var newForm = new LoginScreen();
                newForm.Show();
                this.Hide();
            }
            else if (Program.Debug == 1)
            {
                // Add Threadding here
                var newForm = new LoginScreen();
                newForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("An Error has occcured Please try again");
                Environment.Exit(1);
            }
           
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
