namespace CH_06_HOT
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
            txtAuthor = new TextBox();
            txtISBN = new TextBox();
            txtKeyword = new TextBox();
            btnAuthor = new Button();
            btnISBN = new Button();
            btnKeyword = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblName = new Label();
            lblDescription = new Label();
            lblAuthor = new Label();
            lblISBN = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 56);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 104);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 1;
            label2.Text = "ISBN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 151);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "Keyword";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(202, 52);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(274, 23);
            txtAuthor.TabIndex = 3;
            txtAuthor.TextChanged += txtAuthor_TextChanged;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(202, 101);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(274, 23);
            txtISBN.TabIndex = 4;
            txtISBN.TextChanged += txtISBN_TextChanged;
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(202, 147);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(274, 23);
            txtKeyword.TabIndex = 5;
            txtKeyword.TextChanged += txtKeyword_TextChanged;
            // 
            // btnAuthor
            // 
            btnAuthor.Location = new Point(565, 52);
            btnAuthor.Name = "btnAuthor";
            btnAuthor.Size = new Size(75, 23);
            btnAuthor.TabIndex = 6;
            btnAuthor.Text = "Search";
            btnAuthor.UseVisualStyleBackColor = true;
            btnAuthor.Click += btnAuthor_Click;
            // 
            // btnISBN
            // 
            btnISBN.Location = new Point(565, 101);
            btnISBN.Name = "btnISBN";
            btnISBN.Size = new Size(75, 23);
            btnISBN.TabIndex = 7;
            btnISBN.Text = "Search";
            btnISBN.UseVisualStyleBackColor = true;
            btnISBN.Click += btnISBN_Click;
            // 
            // btnKeyword
            // 
            btnKeyword.Location = new Point(565, 147);
            btnKeyword.Name = "btnKeyword";
            btnKeyword.Size = new Size(75, 23);
            btnKeyword.TabIndex = 8;
            btnKeyword.Text = "Search";
            btnKeyword.UseVisualStyleBackColor = true;
            btnKeyword.Click += btnKeyword_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 243);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 9;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 292);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 10;
            label5.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 345);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 11;
            label6.Text = "Author";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(54, 398);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 12;
            label7.Text = "ISBN-13";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(162, 243);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 15);
            lblName.TabIndex = 13;
            lblName.Click += lblName_Click;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(162, 292);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(0, 15);
            lblDescription.TabIndex = 14;
            lblDescription.Click += lblDescription_Click;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(162, 345);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(0, 15);
            lblAuthor.TabIndex = 15;
            lblAuthor.Click += lblAuthor_Click;
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Location = new Point(162, 398);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(0, 15);
            lblISBN.TabIndex = 16;
            lblISBN.Click += lblISBN_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblISBN);
            Controls.Add(lblAuthor);
            Controls.Add(lblDescription);
            Controls.Add(lblName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnKeyword);
            Controls.Add(btnISBN);
            Controls.Add(btnAuthor);
            Controls.Add(txtKeyword);
            Controls.Add(txtISBN);
            Controls.Add(txtAuthor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Books and Antiques";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAuthor;
        private TextBox txtISBN;
        private TextBox txtKeyword;
        private Button btnAuthor;
        private Button btnISBN;
        private Button btnKeyword;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblName;
        private Label lblDescription;
        private Label lblAuthor;
        private Label lblISBN;
    }
}
