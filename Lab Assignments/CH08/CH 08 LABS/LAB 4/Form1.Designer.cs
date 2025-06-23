namespace LAB_4
{
    partial class MovieDatabase
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
            lblName = new Label();
            label3 = new Label();
            lblDirector = new Label();
            label5 = new Label();
            lblDescription = new Label();
            SuspendLayout();
            // 
            // txtUserInput
            // 
            txtUserInput.Location = new Point(103, 73);
            txtUserInput.Name = "txtUserInput";
            txtUserInput.Size = new Size(295, 23);
            txtUserInput.TabIndex = 0;
            txtUserInput.TextChanged += txtUserInput_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(451, 73);
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
            label1.Location = new Point(103, 226);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(232, 226);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 15);
            lblName.TabIndex = 3;
            lblName.Click += lblName_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 291);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 4;
            label3.Text = "Director:";
            // 
            // lblDirector
            // 
            lblDirector.AutoSize = true;
            lblDirector.Location = new Point(232, 291);
            lblDirector.Name = "lblDirector";
            lblDirector.Size = new Size(0, 15);
            lblDirector.TabIndex = 5;
            lblDirector.Click += lblDirector_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(103, 353);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 6;
            label5.Text = "Description:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(232, 353);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(0, 15);
            lblDescription.TabIndex = 7;
            lblDescription.Click += lblDescription_Click;
            // 
            // MovieDatabase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDescription);
            Controls.Add(label5);
            Controls.Add(lblDirector);
            Controls.Add(label3);
            Controls.Add(lblName);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(txtUserInput);
            Name = "MovieDatabase";
            Text = "MovieDatabase";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserInput;
        private Button btnSearch;
        private Label label1;
        private Label lblName;
        private Label label3;
        private Label lblDirector;
        private Label label5;
        private Label lblDescription;
    }
}
