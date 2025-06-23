namespace LAB_2
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
            lblNightlyCost = new Label();
            lblTotal = new Label();
            txtNights = new TextBox();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 109);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Nights Stayed";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(420, 109);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 1;
            label2.Text = "Nightly Cost";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(560, 109);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 2;
            label3.Text = "Total cost of stay";
            // 
            // lblNightlyCost
            // 
            lblNightlyCost.AutoSize = true;
            lblNightlyCost.Location = new Point(420, 164);
            lblNightlyCost.Name = "lblNightlyCost";
            lblNightlyCost.Size = new Size(0, 15);
            lblNightlyCost.TabIndex = 3;
            lblNightlyCost.Click += lblNightlyCost_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(560, 164);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 15);
            lblTotal.TabIndex = 4;
            lblTotal.Click += lblTotal_Click;
            // 
            // txtNights
            // 
            txtNights.Location = new Point(56, 161);
            txtNights.Name = "txtNights";
            txtNights.Size = new Size(100, 23);
            txtNights.TabIndex = 5;
            txtNights.TextChanged += txtNights_TextChanged;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(253, 161);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 6;
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
            Controls.Add(txtNights);
            Controls.Add(lblTotal);
            Controls.Add(lblNightlyCost);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "The Carefree Resort";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblNightlyCost;
        private Label lblTotal;
        private TextBox txtNights;
        private Button btnCalculate;
    }
}
