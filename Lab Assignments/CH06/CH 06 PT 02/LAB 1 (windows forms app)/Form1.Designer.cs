namespace LAB_1__windows_forms_app_
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
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            txtNum3 = new TextBox();
            txtNum4 = new TextBox();
            btnReverse = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(92, 107);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 0;
            txtNum1.TextChanged += txtNum1_TextChanged;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(273, 107);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 1;
            txtNum2.TextChanged += txtNum2_TextChanged;
            // 
            // txtNum3
            // 
            txtNum3.Location = new Point(466, 107);
            txtNum3.Name = "txtNum3";
            txtNum3.Size = new Size(100, 23);
            txtNum3.TabIndex = 2;
            txtNum3.TextChanged += txtNum3_TextChanged;
            // 
            // txtNum4
            // 
            txtNum4.Location = new Point(627, 107);
            txtNum4.Name = "txtNum4";
            txtNum4.Size = new Size(100, 23);
            txtNum4.TabIndex = 3;
            txtNum4.TextChanged += txtNum4_TextChanged;
            // 
            // btnReverse
            // 
            btnReverse.Location = new Point(349, 232);
            btnReverse.Name = "btnReverse";
            btnReverse.Size = new Size(75, 23);
            btnReverse.TabIndex = 4;
            btnReverse.Text = "Reverse";
            btnReverse.UseVisualStyleBackColor = true;
            btnReverse.Click += btnReverse_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(335, 293);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(52, 15);
            lblResult.TabIndex = 5;
            lblResult.Text = "lblResult";
            lblResult.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnReverse);
            Controls.Add(txtNum4);
            Controls.Add(txtNum3);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Name = "Form1";
            Text = "Reverse4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtNum3;
        private TextBox txtNum4;
        private Button btnReverse;
        private Label lblResult;
    }
}
