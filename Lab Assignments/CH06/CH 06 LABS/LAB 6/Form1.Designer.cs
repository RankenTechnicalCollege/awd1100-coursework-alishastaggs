namespace LAB_6
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
            txtDrawers = new TextBox();
            txtWood = new TextBox();
            btnEstimate = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblWood = new Label();
            lblDrawers = new Label();
            label6 = new Label();
            label7 = new Label();
            lblTotalCost = new Label();
            lblCostWood = new Label();
            SuspendLayout();
            // 
            // txtDrawers
            // 
            txtDrawers.Location = new Point(351, 122);
            txtDrawers.Name = "txtDrawers";
            txtDrawers.Size = new Size(100, 23);
            txtDrawers.TabIndex = 0;
            txtDrawers.TextChanged += txtDrawers_TextChanged;
            // 
            // txtWood
            // 
            txtWood.Location = new Point(125, 122);
            txtWood.Name = "txtWood";
            txtWood.Size = new Size(100, 23);
            txtWood.TabIndex = 1;
            txtWood.TextChanged += txtWood_TextChanged;
            // 
            // btnEstimate
            // 
            btnEstimate.Location = new Point(125, 177);
            btnEstimate.Name = "btnEstimate";
            btnEstimate.Size = new Size(75, 23);
            btnEstimate.TabIndex = 2;
            btnEstimate.Text = "Estimate";
            btnEstimate.UseVisualStyleBackColor = true;
            btnEstimate.Click += btnEstimate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 75);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 3;
            label1.Text = "Type of Wood";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(351, 75);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 4;
            label2.Text = "Number of Drawers";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 268);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 5;
            label3.Text = "Cost of Wood";
            // 
            // lblWood
            // 
            lblWood.AutoSize = true;
            lblWood.Location = new Point(125, 330);
            lblWood.Name = "lblWood";
            lblWood.Size = new Size(0, 15);
            lblWood.TabIndex = 6;
            lblWood.Click += lblWood_Click;
            // 
            // lblDrawers
            // 
            lblDrawers.AutoSize = true;
            lblDrawers.Location = new Point(351, 268);
            lblDrawers.Name = "lblDrawers";
            lblDrawers.Size = new Size(90, 15);
            lblDrawers.TabIndex = 7;
            lblDrawers.Text = "Cost of Drawers";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(351, 330);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 8;
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(598, 268);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 9;
            label7.Text = "Total Cost";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Location = new Point(598, 330);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(0, 15);
            lblTotalCost.TabIndex = 10;
            lblTotalCost.Click += lblTotalCost_Click;
            // 
            // lblCostWood
            // 
            lblCostWood.AutoSize = true;
            lblCostWood.Location = new Point(125, 330);
            lblCostWood.Name = "lblCostWood";
            lblCostWood.Size = new Size(0, 15);
            lblCostWood.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCostWood);
            Controls.Add(lblTotalCost);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lblDrawers);
            Controls.Add(lblWood);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEstimate);
            Controls.Add(txtWood);
            Controls.Add(txtDrawers);
            Name = "Form1";
            Text = "My Custom Desk";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDrawers;
        private TextBox txtWood;
        private Button btnEstimate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblWood;
        private Label lblDrawers;
        private Label label6;
        private Label label7;
        private Label lblTotalCost;
        private Label lblCostWood;
    }
}
