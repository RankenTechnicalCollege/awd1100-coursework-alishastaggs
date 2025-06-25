namespace LAB_4
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
            label3 = new Label();
            label4 = new Label();
            lblArea = new Label();
            lblTotalCost = new Label();
            txtLength = new TextBox();
            txtWidth = new TextBox();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 104);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Length (ft)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 104);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Width (ft)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(447, 104);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 2;
            label3.Text = "Total Area (sq ft)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(601, 104);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 3;
            label4.Text = "Total Cost ($)";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(447, 155);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(0, 15);
            lblArea.TabIndex = 4;
            lblArea.Click += lblArea_Click;
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Location = new Point(601, 155);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(0, 15);
            lblTotalCost.TabIndex = 5;
            lblTotalCost.Click += lblTotalCost_Click;
            // 
            // txtLength
            // 
            txtLength.Location = new Point(16, 150);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(100, 23);
            txtLength.TabIndex = 6;
            txtLength.TextChanged += txtLength_TextChanged;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(143, 150);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(100, 23);
            txtWidth.TabIndex = 7;
            txtWidth.TextChanged += txtWidth_TextChanged;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(307, 150);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculate);
            Controls.Add(txtWidth);
            Controls.Add(txtLength);
            Controls.Add(lblTotalCost);
            Controls.Add(lblArea);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Painting Estimate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblArea;
        private Label lblTotalCost;
        private TextBox txtLength;
        private TextBox txtWidth;
        private Button btnCalculate;
    }
}
