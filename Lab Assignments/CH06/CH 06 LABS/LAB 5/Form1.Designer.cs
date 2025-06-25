namespace LAB_5
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
            lblResult = new Label();
            btnMask = new Button();
            txtUserInput = new TextBox();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(93, 240);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 0;
            lblResult.Click += lblResult_Click;
            // 
            // btnMask
            // 
            btnMask.Location = new Point(414, 150);
            btnMask.Name = "btnMask";
            btnMask.Size = new Size(75, 23);
            btnMask.TabIndex = 1;
            btnMask.Text = "Mask";
            btnMask.UseVisualStyleBackColor = true;
            btnMask.Click += btnMask_Click;
            // 
            // txtUserInput
            // 
            txtUserInput.Location = new Point(93, 150);
            txtUserInput.Name = "txtUserInput";
            txtUserInput.Size = new Size(219, 23);
            txtUserInput.TabIndex = 2;
            txtUserInput.TextChanged += txtUserInput_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtUserInput);
            Controls.Add(btnMask);
            Controls.Add(lblResult);
            Name = "Form1";
            Text = "Credit Card Masker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResult;
        private Button btnMask;
        private TextBox txtUserInput;
    }
}
