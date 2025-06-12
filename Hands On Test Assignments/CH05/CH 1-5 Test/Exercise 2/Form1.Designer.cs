namespace Exercise_2
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
            label2 = new Label();
            lblGrade = new Label();
            txtGpa = new TextBox();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 74);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Numeric Grade";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 253);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 1;
            label2.Text = "Your Grade:";
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Location = new Point(135, 253);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(0, 15);
            lblGrade.TabIndex = 2;
            lblGrade.Click += lblGrade_Click;
            // 
            // txtGpa
            // 
            txtGpa.Location = new Point(73, 126);
            txtGpa.Name = "txtGpa";
            txtGpa.Size = new Size(118, 23);
            txtGpa.TabIndex = 3;
            txtGpa.TextChanged += txtGpa_TextChanged;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(73, 182);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(118, 23);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Show Letter Grade";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculate);
            Controls.Add(txtGpa);
            Controls.Add(lblGrade);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Letter Grade";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblGrade;
        private TextBox txtGpa;
        private Button btnCalculate;
    }
}
