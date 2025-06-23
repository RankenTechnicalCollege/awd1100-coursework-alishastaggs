namespace CH_01_08_HOT
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
            txtUserInput = new TextBox();
            btnSearch = new Button();
            label1 = new Label();
            lblPhoneNumber = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblInvalid = new Label();
            SuspendLayout();
            // 
            // txtUserInput
            // 
            txtUserInput.Location = new Point(109, 104);
            txtUserInput.Name = "txtUserInput";
            txtUserInput.Size = new Size(217, 23);
            txtUserInput.TabIndex = 0;
            txtUserInput.TextChanged += txtUserInput_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(376, 104);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 64);
            label1.Name = "label1";
            label1.Size = new Size(137, 15);
            label1.TabIndex = 2;
            label1.Text = "First Name or Last Name";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(195, 285);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(0, 15);
            lblPhoneNumber.TabIndex = 3;
            lblPhoneNumber.Click += lblPhoneNumber_Click;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(195, 229);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(0, 15);
            lblLastName.TabIndex = 4;
            lblLastName.Click += lblLastName_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(195, 180);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(0, 15);
            lblFirstName.TabIndex = 5;
            lblFirstName.Click += lblFirstName_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(109, 285);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 6;
            label5.Text = "Phone #";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(109, 229);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 7;
            label6.Text = "Last Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(109, 180);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 8;
            label7.Text = "First Name";
            // 
            // lblInvalid
            // 
            lblInvalid.AutoSize = true;
            lblInvalid.Location = new Point(376, 362);
            lblInvalid.Name = "lblInvalid";
            lblInvalid.Size = new Size(0, 15);
            lblInvalid.TabIndex = 9;
            lblInvalid.Click += lblInvalid_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblInvalid);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblFirstName);
            Controls.Add(lblLastName);
            Controls.Add(lblPhoneNumber);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(txtUserInput);
            Name = "Form1";
            Text = "Adress Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserInput;
        private Button btnSearch;
        private Label label1;
        private Label lblPhoneNumber;
        private Label lblLastName;
        private Label lblFirstName;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblInvalid;
    }
}
