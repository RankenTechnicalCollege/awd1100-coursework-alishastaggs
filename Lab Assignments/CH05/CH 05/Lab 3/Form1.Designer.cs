namespace Lab_3
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
            BtnRock = new Button();
            btnPaper = new Button();
            btnScissors = new Button();
            label1 = new Label();
            lblCompPicked = new Label();
            label3 = new Label();
            lblPlayerScore = new Label();
            label5 = new Label();
            lblCompScore = new Label();
            lblResult = new Label();
            SuspendLayout();
            // 
            // BtnRock
            // 
            BtnRock.Location = new Point(105, 61);
            BtnRock.Name = "BtnRock";
            BtnRock.Size = new Size(75, 23);
            BtnRock.TabIndex = 0;
            BtnRock.Text = "Rock";
            BtnRock.UseVisualStyleBackColor = true;
            BtnRock.Click += BtnRock_Click;
            // 
            // btnPaper
            // 
            btnPaper.Location = new Point(295, 61);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(75, 23);
            btnPaper.TabIndex = 1;
            btnPaper.Text = "Paper";
            btnPaper.UseVisualStyleBackColor = true;
            btnPaper.Click += btnPaper_Click;
            // 
            // btnScissors
            // 
            btnScissors.Location = new Point(471, 61);
            btnScissors.Name = "btnScissors";
            btnScissors.Size = new Size(75, 23);
            btnScissors.TabIndex = 2;
            btnScissors.Text = "Scissors";
            btnScissors.UseVisualStyleBackColor = true;
            btnScissors.Click += btnScissors_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 156);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 3;
            label1.Text = "Computer picked";
            // 
            // lblCompPicked
            // 
            lblCompPicked.AutoSize = true;
            lblCompPicked.Location = new Point(200, 156);
            lblCompPicked.Name = "lblCompPicked";
            lblCompPicked.Size = new Size(0, 15);
            lblCompPicked.TabIndex = 4;
            lblCompPicked.Click += lblCompPicked_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 225);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 5;
            label3.Text = "Player Score:";
            // 
            // lblPlayerScore
            // 
            lblPlayerScore.AutoSize = true;
            lblPlayerScore.Location = new Point(175, 225);
            lblPlayerScore.Name = "lblPlayerScore";
            lblPlayerScore.Size = new Size(0, 15);
            lblPlayerScore.TabIndex = 6;
            lblPlayerScore.Click += lblPlayerScore_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(295, 225);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 7;
            label5.Text = "Computer Score:";
            // 
            // lblCompScore
            // 
            lblCompScore.AutoSize = true;
            lblCompScore.Location = new Point(388, 225);
            lblCompScore.Name = "lblCompScore";
            lblCompScore.Size = new Size(0, 15);
            lblCompScore.TabIndex = 8;
            lblCompScore.Click += lblCompScore_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(105, 304);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 9;
            lblResult.Click += lblResult_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(lblCompScore);
            Controls.Add(label5);
            Controls.Add(lblPlayerScore);
            Controls.Add(label3);
            Controls.Add(lblCompPicked);
            Controls.Add(label1);
            Controls.Add(btnScissors);
            Controls.Add(btnPaper);
            Controls.Add(BtnRock);
            Name = "Form1";
            Text = "Rock, Paper, Scissors";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnRock;
        private Button btnPaper;
        private Button btnScissors;
        private Label label1;
        private Label lblCompPicked;
        private Label label3;
        private Label lblPlayerScore;
        private Label label5;
        private Label lblCompScore;
        private Label lblResult;
    }
}
