namespace LAB_7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDeposit = new TextBox();
            txtWithdrawal = new TextBox();
            txtPin = new TextBox();
            txtAccount = new TextBox();
            btnLogout = new Button();
            btnWithdraw = new Button();
            btnDeposit = new Button();
            btnLogin = new Button();
            lblWelcome = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtDeposit
            // 
            txtDeposit.Location = new Point(99, 252);
            txtDeposit.Name = "txtDeposit";
            txtDeposit.Size = new Size(100, 23);
            txtDeposit.TabIndex = 0;
            txtDeposit.TextChanged += txtDeposit_TextChanged;
            // 
            // txtWithdrawal
            // 
            txtWithdrawal.Location = new Point(99, 318);
            txtWithdrawal.Name = "txtWithdrawal";
            txtWithdrawal.Size = new Size(100, 23);
            txtWithdrawal.TabIndex = 1;
            txtWithdrawal.TextChanged += txtWithdrawal_TextChanged;
            // 
            // txtPin
            // 
            txtPin.Location = new Point(326, 95);
            txtPin.Name = "txtPin";
            txtPin.Size = new Size(100, 23);
            txtPin.TabIndex = 2;
            txtPin.TextChanged += txtPin_TextChanged;
            // 
            // txtAccount
            // 
            txtAccount.Location = new Point(326, 36);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(100, 23);
            txtAccount.TabIndex = 3;
            txtAccount.TextChanged += txtAccount_TextChanged;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(351, 386);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(564, 318);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(75, 23);
            btnWithdraw.TabIndex = 5;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(564, 251);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(75, 23);
            btnDeposit.TabIndex = 6;
            btnDeposit.Text = "deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(564, 73);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(364, 175);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(38, 15);
            lblWelcome.TabIndex = 8;
            lblWelcome.Text = "label1";
            lblWelcome.Click += lblWelcome_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 103);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 9;
            label2.Text = "Pin #";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(184, 44);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 10;
            label3.Text = "Account #";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(99, 289);
            label4.Name = "label4";
            label4.Size = new Size(207, 15);
            label4.TabIndex = 11;
            label4.Text = "Would you like to make a withdrawal?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(99, 221);
            label5.Name = "label5";
            label5.Size = new Size(188, 15);
            label5.TabIndex = 12;
            label5.Text = "Would you like to make a deposit?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblWelcome);
            Controls.Add(btnLogin);
            Controls.Add(btnDeposit);
            Controls.Add(btnWithdraw);
            Controls.Add(btnLogout);
            Controls.Add(txtAccount);
            Controls.Add(txtPin);
            Controls.Add(txtWithdrawal);
            Controls.Add(txtDeposit);
            Name = "Form1";
            Text = "Weyland Bank";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDeposit;
        private TextBox txtWithdrawal;
        private TextBox txtPin;
        private TextBox txtAccount;
        private Button btnLogout;
        private Button btnWithdraw;
        private Button btnDeposit;
        private Button btnLogin;
        private Label lblWelcome;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
