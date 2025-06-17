namespace Lab_5
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
            label1 = new Label();
            lblVowels = new Label();
            txtPhrase = new TextBox();
            btnEnter = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 50);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 0;
            label1.Text = "Please enter a phrase";
            // 
            // lblVowels
            // 
            lblVowels.AutoSize = true;
            lblVowels.Location = new Point(45, 161);
            lblVowels.Name = "lblVowels";
            lblVowels.Size = new Size(0, 15);
            lblVowels.TabIndex = 1;
            lblVowels.Click += lblVowels_Click;
            // 
            // txtPhrase
            // 
            txtPhrase.Location = new Point(45, 100);
            txtPhrase.Name = "txtPhrase";
            txtPhrase.Size = new Size(100, 23);
            txtPhrase.TabIndex = 2;
            txtPhrase.TextChanged += txtPhrase_TextChanged;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(205, 100);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(75, 23);
            btnEnter.TabIndex = 3;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEnter);
            Controls.Add(txtPhrase);
            Controls.Add(lblVowels);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblVowels;
        private TextBox txtPhrase;
        private Button btnEnter;
    }
}
