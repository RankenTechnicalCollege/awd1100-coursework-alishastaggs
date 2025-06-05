namespace Lab_2
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
            lblResult = new Label();
            btnCalculate = new Button();
            txtChicken1 = new TextBox();
            txtChicken2 = new TextBox();
            txtChicken3 = new TextBox();
            txtChicken4 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(279, 42);
            label1.Name = "label1";
            label1.Size = new Size(231, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter number of eggs laid by each chicken";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(279, 329);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 1;
            lblResult.Click += lblResult_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(279, 131);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(231, 95);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtChicken1
            // 
            txtChicken1.Location = new Point(117, 85);
            txtChicken1.Name = "txtChicken1";
            txtChicken1.Size = new Size(100, 23);
            txtChicken1.TabIndex = 3;
            txtChicken1.TextChanged += txtChicken1_TextChanged;
            // 
            // txtChicken2
            // 
            txtChicken2.Location = new Point(267, 85);
            txtChicken2.Name = "txtChicken2";
            txtChicken2.Size = new Size(100, 23);
            txtChicken2.TabIndex = 4;
            txtChicken2.TextChanged += txtChicken2_TextChanged;
            // 
            // txtChicken3
            // 
            txtChicken3.Location = new Point(427, 85);
            txtChicken3.Name = "txtChicken3";
            txtChicken3.Size = new Size(100, 23);
            txtChicken3.TabIndex = 5;
            txtChicken3.TextChanged += txtChicken3_TextChanged;
            // 
            // txtChicken4
            // 
            txtChicken4.Location = new Point(590, 85);
            txtChicken4.Name = "txtChicken4";
            txtChicken4.Size = new Size(100, 23);
            txtChicken4.TabIndex = 6;
            txtChicken4.TextChanged += txtChicken4_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtChicken4);
            Controls.Add(txtChicken3);
            Controls.Add(txtChicken2);
            Controls.Add(txtChicken1);
            Controls.Add(btnCalculate);
            Controls.Add(lblResult);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Chicken Farmer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblResult;
        private Button btnCalculate;
        private TextBox txtChicken1;
        private TextBox txtChicken2;
        private TextBox txtChicken3;
        private TextBox txtChicken4;
    }
}
