namespace ATMSimulatorAssignment
{
    partial class LoginScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LogInTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.AccountNumberLabel = new System.Windows.Forms.Label();
            this.PinLabel = new System.Windows.Forms.Label();
            this.LogInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogInTextBox
            // 
            this.LogInTextBox.Location = new System.Drawing.Point(15, 25);
            this.LogInTextBox.Name = "LogInTextBox";
            this.LogInTextBox.Size = new System.Drawing.Size(129, 20);
            this.LogInTextBox.TabIndex = 0;
            this.LogInTextBox.TextChanged += new System.EventHandler(this.LogInTextBox_TextChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(15, 64);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(129, 20);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // AccountNumberLabel
            // 
            this.AccountNumberLabel.AutoSize = true;
            this.AccountNumberLabel.Location = new System.Drawing.Point(12, 9);
            this.AccountNumberLabel.Name = "AccountNumberLabel";
            this.AccountNumberLabel.Size = new System.Drawing.Size(90, 13);
            this.AccountNumberLabel.TabIndex = 2;
            this.AccountNumberLabel.Text = "Account Number:";
            // 
            // PinLabel
            // 
            this.PinLabel.AutoSize = true;
            this.PinLabel.Location = new System.Drawing.Point(12, 48);
            this.PinLabel.Name = "PinLabel";
            this.PinLabel.Size = new System.Drawing.Size(28, 13);
            this.PinLabel.TabIndex = 3;
            this.PinLabel.Text = "PIN:";
            // 
            // LogInButton
            // 
            this.LogInButton.Location = new System.Drawing.Point(15, 90);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(129, 23);
            this.LogInButton.TabIndex = 4;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(159, 124);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.PinLabel);
            this.Controls.Add(this.AccountNumberLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LogInTextBox);
            this.Name = "LoginScreen";
            this.Text = "LoginScreen";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LogInTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label AccountNumberLabel;
        private System.Windows.Forms.Label PinLabel;
        private System.Windows.Forms.Button LogInButton;
    }
}