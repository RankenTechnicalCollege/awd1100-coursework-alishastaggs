namespace Lab_4
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
            lblDanielle = new Label();
            lblEdward = new Label();
            lblFrancis = new Label();
            lblTotal = new Label();
            lblMostSales = new Label();
            txtSales = new TextBox();
            btnDanielle = new Button();
            btnEdward = new Button();
            btnFrancis = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 52);
            label1.Name = "label1";
            label1.Size = new Size(137, 15);
            label1.TabIndex = 0;
            label1.Text = "How much was the sale?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 125);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 1;
            label2.Text = "Who made the sale?";
            // 
            // lblDanielle
            // 
            lblDanielle.AutoSize = true;
            lblDanielle.Location = new Point(40, 219);
            lblDanielle.Name = "lblDanielle";
            lblDanielle.Size = new Size(0, 15);
            lblDanielle.TabIndex = 2;
            lblDanielle.Click += lblDanielle_Click;
            // 
            // lblEdward
            // 
            lblEdward.AutoSize = true;
            lblEdward.Location = new Point(40, 254);
            lblEdward.Name = "lblEdward";
            lblEdward.Size = new Size(0, 15);
            lblEdward.TabIndex = 3;
            lblEdward.Click += lblEdward_Click;
            // 
            // lblFrancis
            // 
            lblFrancis.AutoSize = true;
            lblFrancis.Location = new Point(40, 288);
            lblFrancis.Name = "lblFrancis";
            lblFrancis.Size = new Size(0, 15);
            lblFrancis.TabIndex = 4;
            lblFrancis.Click += lblFrancis_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(40, 326);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 15);
            lblTotal.TabIndex = 5;
            lblTotal.Click += lblTotal_Click;
            // 
            // lblMostSales
            // 
            lblMostSales.AutoSize = true;
            lblMostSales.Location = new Point(40, 403);
            lblMostSales.Name = "lblMostSales";
            lblMostSales.Size = new Size(0, 15);
            lblMostSales.TabIndex = 6;
            lblMostSales.Click += lblMostSales_Click;
            // 
            // txtSales
            // 
            txtSales.Location = new Point(40, 79);
            txtSales.Name = "txtSales";
            txtSales.Size = new Size(100, 23);
            txtSales.TabIndex = 7;
            txtSales.TextChanged += txtSales_TextChanged;
            // 
            // btnDanielle
            // 
            btnDanielle.Location = new Point(40, 155);
            btnDanielle.Name = "btnDanielle";
            btnDanielle.Size = new Size(75, 23);
            btnDanielle.TabIndex = 8;
            btnDanielle.Text = "Danielle";
            btnDanielle.UseVisualStyleBackColor = true;
            btnDanielle.Click += btnDanielle_Click;
            // 
            // btnEdward
            // 
            btnEdward.Location = new Point(156, 155);
            btnEdward.Name = "btnEdward";
            btnEdward.Size = new Size(75, 23);
            btnEdward.TabIndex = 9;
            btnEdward.Text = "Edward";
            btnEdward.UseVisualStyleBackColor = true;
            btnEdward.Click += btnEdward_Click;
            // 
            // btnFrancis
            // 
            btnFrancis.Location = new Point(278, 155);
            btnFrancis.Name = "btnFrancis";
            btnFrancis.Size = new Size(75, 23);
            btnFrancis.TabIndex = 10;
            btnFrancis.Text = "Francis";
            btnFrancis.UseVisualStyleBackColor = true;
            btnFrancis.Click += btnFrancis_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFrancis);
            Controls.Add(btnEdward);
            Controls.Add(btnDanielle);
            Controls.Add(txtSales);
            Controls.Add(lblMostSales);
            Controls.Add(lblTotal);
            Controls.Add(lblFrancis);
            Controls.Add(lblEdward);
            Controls.Add(lblDanielle);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Home Sales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblDanielle;
        private Label lblEdward;
        private Label lblFrancis;
        private Label lblTotal;
        private Label lblMostSales;
        private TextBox txtSales;
        private Button btnDanielle;
        private Button btnEdward;
        private Button btnFrancis;
    }
}
