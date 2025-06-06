namespace Exercise_3
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
            txtWidth = new TextBox();
            txtLength = new TextBox();
            BtnCalculate = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblTotalCost = new Label();
            lblWeeklyFee = new Label();
            lblArea = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 43);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Length (ft)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(318, 43);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Width (ft)";
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(318, 91);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(100, 23);
            txtWidth.TabIndex = 2;
            txtWidth.TextChanged += txtWidth_TextChanged;
            // 
            // txtLength
            // 
            txtLength.Location = new Point(90, 91);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(100, 23);
            txtLength.TabIndex = 3;
            txtLength.TextChanged += txtLength_TextChanged;
            // 
            // BtnCalculate
            // 
            BtnCalculate.Location = new Point(90, 154);
            BtnCalculate.Name = "BtnCalculate";
            BtnCalculate.Size = new Size(328, 50);
            BtnCalculate.TabIndex = 4;
            BtnCalculate.Text = "Calculate";
            BtnCalculate.UseVisualStyleBackColor = true;
            BtnCalculate.Click += BtnCalculate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 238);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 5;
            label3.Text = "Area:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 283);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 6;
            label4.Text = "Weekly Fee:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(90, 332);
            label5.Name = "label5";
            label5.Size = new Size(137, 15);
            label5.TabIndex = 7;
            label5.Text = "Season Length: 20 weeks";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(90, 379);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 8;
            label6.Text = "Total Cost:";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Location = new Point(159, 379);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(0, 15);
            lblTotalCost.TabIndex = 9;
            lblTotalCost.Click += lblTotalCost_Click;
            // 
            // lblWeeklyFee
            // 
            lblWeeklyFee.AutoSize = true;
            lblWeeklyFee.Location = new Point(165, 283);
            lblWeeklyFee.Name = "lblWeeklyFee";
            lblWeeklyFee.Size = new Size(0, 15);
            lblWeeklyFee.TabIndex = 10;
            lblWeeklyFee.Click += lblWeeklyFee_Click;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(130, 238);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(0, 15);
            lblArea.TabIndex = 11;
            lblArea.Click += lblArea_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblArea);
            Controls.Add(lblWeeklyFee);
            Controls.Add(lblTotalCost);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(BtnCalculate);
            Controls.Add(txtLength);
            Controls.Add(txtWidth);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Greg's Lawncare";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtWidth;
        private TextBox txtLength;
        private Button BtnCalculate;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblTotalCost;
        private Label lblWeeklyFee;
        private Label lblArea;
    }
}
