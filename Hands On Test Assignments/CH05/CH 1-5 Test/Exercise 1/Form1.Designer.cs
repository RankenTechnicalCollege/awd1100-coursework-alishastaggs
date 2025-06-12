namespace Exercise_1
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
            txtInches = new TextBox();
            btnConvert = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 47);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "Distance in inches";
            label1.Click += label1_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(85, 215);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 1;
            lblResult.Click += lblResult_Click;
            // 
            // txtInches
            // 
            txtInches.Location = new Point(85, 99);
            txtInches.Name = "txtInches";
            txtInches.Size = new Size(100, 23);
            txtInches.TabIndex = 2;
            txtInches.TextChanged += txtInches_TextChanged;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(85, 156);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(100, 23);
            btnConvert.TabIndex = 3;
            btnConvert.Text = "Convert to cm";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConvert);
            Controls.Add(txtInches);
            Controls.Add(lblResult);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Distance Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblResult;
        private TextBox txtInches;
        private Button btnConvert;
    }
}
