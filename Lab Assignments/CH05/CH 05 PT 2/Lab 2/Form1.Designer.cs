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
            lblNumOfScores = new Label();
            lblSum = new Label();
            lblAverage = new Label();
            lblLowest = new Label();
            lblHighest = new Label();
            label6 = new Label();
            txtScore = new TextBox();
            btnEnter = new Button();
            SuspendLayout();
            // 
            // lblNumOfScores
            // 
            lblNumOfScores.AutoSize = true;
            lblNumOfScores.Location = new Point(49, 190);
            lblNumOfScores.Name = "lblNumOfScores";
            lblNumOfScores.Size = new Size(0, 15);
            lblNumOfScores.TabIndex = 0;
            lblNumOfScores.Click += lblNumOfScores_Click;
            // 
            // lblSum
            // 
            lblSum.AutoSize = true;
            lblSum.Location = new Point(49, 249);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(0, 15);
            lblSum.TabIndex = 1;
            lblSum.Click += lblSum_Click;
            // 
            // lblAverage
            // 
            lblAverage.AutoSize = true;
            lblAverage.Location = new Point(49, 309);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(0, 15);
            lblAverage.TabIndex = 2;
            lblAverage.Click += lblAverage_Click;
            // 
            // lblLowest
            // 
            lblLowest.AutoSize = true;
            lblLowest.Location = new Point(49, 358);
            lblLowest.Name = "lblLowest";
            lblLowest.Size = new Size(0, 15);
            lblLowest.TabIndex = 3;
            lblLowest.Click += lblLowest_Click;
            // 
            // lblHighest
            // 
            lblHighest.AutoSize = true;
            lblHighest.Location = new Point(49, 411);
            lblHighest.Name = "lblHighest";
            lblHighest.Size = new Size(0, 15);
            lblHighest.TabIndex = 4;
            lblHighest.Click += lblHighest_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 64);
            label6.Name = "label6";
            label6.Size = new Size(132, 15);
            label6.TabIndex = 5;
            label6.Text = "please enter a test score";
            // 
            // txtScore
            // 
            txtScore.Location = new Point(48, 97);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(100, 23);
            txtScore.TabIndex = 6;
            txtScore.TextChanged += txtScore_TextChanged;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(48, 141);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(75, 23);
            btnEnter.TabIndex = 7;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEnter);
            Controls.Add(txtScore);
            Controls.Add(label6);
            Controls.Add(lblHighest);
            Controls.Add(lblLowest);
            Controls.Add(lblAverage);
            Controls.Add(lblSum);
            Controls.Add(lblNumOfScores);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumOfScores;
        private Label lblSum;
        private Label lblAverage;
        private Label lblLowest;
        private Label lblHighest;
        private Label label6;
        private TextBox txtScore;
        private Button btnEnter;
    }
}
