﻿using System;
using System.Windows.Forms;

namespace ATMSimulatorAssignment
{
    public partial class MainWindow : Form
    {
        public Account[] accountList;

        public MainWindow(Account [] accountList)
        {
            InitializeComponent();
            this.accountList = accountList;
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Assignment by Harry Finch and Elliot Kinkhead, for AC22005");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DataSafeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool ticked = ((CheckBox)sender).Checked;
            for (int i = 0; i < accountList.Length; i++)
            {
                accountList[i].setDatasafe(ticked);
            }
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            Program.openATM();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
