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
            label2 = new Label();
            lblResult = new Label();
            btnEstimate = new Button();
            txtWind = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(358, 66);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Categpry";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 66);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Wind Speed";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(358, 122);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 2;
            lblResult.Click += lblResult_Click;
            // 
            // btnEstimate
            // 
            btnEstimate.Location = new Point(214, 117);
            btnEstimate.Name = "btnEstimate";
            btnEstimate.Size = new Size(75, 23);
            btnEstimate.TabIndex = 3;
            btnEstimate.Text = "Estimate";
            btnEstimate.UseVisualStyleBackColor = true;
            btnEstimate.Click += btnEstimate_Click;
            // 
            // txtWind
            // 
            txtWind.Location = new Point(44, 117);
            txtWind.Name = "txtWind";
            txtWind.Size = new Size(100, 23);
            txtWind.TabIndex = 4;
            txtWind.TextChanged += txtWind_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtWind);
            Controls.Add(btnEstimate);
            Controls.Add(lblResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Hurricane Scale";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblResult;
        private Button btnEstimate;
        private TextBox txtWind;
    }
}
