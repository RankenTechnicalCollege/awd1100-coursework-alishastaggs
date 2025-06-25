namespace LAB_3
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
            btnEnter = new Button();
            txtUserInput = new TextBox();
            label1 = new Label();
            lblResult = new Label();
            SuspendLayout();
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(238, 154);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(75, 23);
            btnEnter.TabIndex = 0;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // txtUserInput
            // 
            txtUserInput.Location = new Point(97, 155);
            txtUserInput.Name = "txtUserInput";
            txtUserInput.Size = new Size(100, 23);
            txtUserInput.TabIndex = 1;
            txtUserInput.TextChanged += txtUserInput_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 104);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 2;
            label1.Text = "Please enter a phrase";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(98, 262);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 3;
            lblResult.Click += lblResult_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(label1);
            Controls.Add(txtUserInput);
            Controls.Add(btnEnter);
            Name = "Form1";
            Text = "Vowels";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnter;
        private TextBox txtUserInput;
        private Label label1;
        private Label lblResult;
    }
}
