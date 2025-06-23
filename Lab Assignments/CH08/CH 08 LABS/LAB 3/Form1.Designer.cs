namespace LAB_3
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
            lblPrice = new Label();
            label3 = new Label();
            lblPublisher = new Label();
            label5 = new Label();
            lblName = new Label();
            btnSearch = new Button();
            txtUserInput = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 196);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(204, 308);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(0, 15);
            lblPrice.TabIndex = 1;
            lblPrice.Click += lblPrice_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 308);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Price:";
            // 
            // lblPublisher
            // 
            lblPublisher.AutoSize = true;
            lblPublisher.Location = new Point(204, 252);
            lblPublisher.Name = "lblPublisher";
            lblPublisher.Size = new Size(0, 15);
            lblPublisher.TabIndex = 3;
            lblPublisher.Click += lblPublisher_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(101, 252);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 4;
            label5.Text = "Publisher:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(204, 196);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 15);
            lblName.TabIndex = 5;
            lblName.Click += lblName_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(369, 118);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtUserInput
            // 
            txtUserInput.Location = new Point(101, 118);
            txtUserInput.Name = "txtUserInput";
            txtUserInput.Size = new Size(195, 23);
            txtUserInput.TabIndex = 7;
            txtUserInput.TextChanged += txtUserInput_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtUserInput);
            Controls.Add(btnSearch);
            Controls.Add(lblName);
            Controls.Add(label5);
            Controls.Add(lblPublisher);
            Controls.Add(label3);
            Controls.Add(lblPrice);
            Controls.Add(label1);
            Name = "Form1";
            Text = "GameBreak";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblPrice;
        private Label label3;
        private Label lblPublisher;
        private Label label5;
        private Label lblName;
        private Button btnSearch;
        private TextBox txtUserInput;
    }
}
