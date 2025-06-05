namespace Lab_1
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
            btnConvertToKilo = new Button();
            lblresult1 = new Label();
            txtmiles = new TextBox();
            lblDisInMiles = new Label();
            lblDisToKilo = new Label();
            lblResult2 = new Label();
            txtKilometers = new TextBox();
            BtnConvertToMiles = new Button();
            SuspendLayout();
            // 
            // btnConvertToKilo
            // 
            btnConvertToKilo.Location = new Point(71, 149);
            btnConvertToKilo.Name = "btnConvertToKilo";
            btnConvertToKilo.Size = new Size(191, 81);
            btnConvertToKilo.TabIndex = 0;
            btnConvertToKilo.Text = "Convert";
            btnConvertToKilo.UseVisualStyleBackColor = true;
            btnConvertToKilo.Click += btnConvertToKilo_Click;
            // 
            // lblresult1
            // 
            lblresult1.AutoSize = true;
            lblresult1.Location = new Point(71, 265);
            lblresult1.Name = "lblresult1";
            lblresult1.Size = new Size(0, 15);
            lblresult1.TabIndex = 1;
            lblresult1.Click += lblresult1_Click;
            // 
            // txtmiles
            // 
            txtmiles.Location = new Point(71, 94);
            txtmiles.Name = "txtmiles";
            txtmiles.Size = new Size(191, 23);
            txtmiles.TabIndex = 2;
            txtmiles.TextChanged += txtmiles_TextChanged;
            // 
            // lblDisInMiles
            // 
            lblDisInMiles.AutoSize = true;
            lblDisInMiles.Location = new Point(71, 48);
            lblDisInMiles.Name = "lblDisInMiles";
            lblDisInMiles.Size = new Size(96, 15);
            lblDisInMiles.TabIndex = 3;
            lblDisInMiles.Text = "Distance in miles";
            lblDisInMiles.Click += label2_Click;
            // 
            // lblDisToKilo
            // 
            lblDisToKilo.AutoSize = true;
            lblDisToKilo.Location = new Point(336, 48);
            lblDisToKilo.Name = "lblDisToKilo";
            lblDisToKilo.Size = new Size(123, 15);
            lblDisToKilo.TabIndex = 4;
            lblDisToKilo.Text = "Distance in kilometers";
            lblDisToKilo.Click += lblDisToKilo_Click;
            // 
            // lblResult2
            // 
            lblResult2.AutoSize = true;
            lblResult2.Location = new Point(336, 265);
            lblResult2.Name = "lblResult2";
            lblResult2.Size = new Size(0, 15);
            lblResult2.TabIndex = 5;
            lblResult2.Click += lblResult2_Click;
            // 
            // txtKilometers
            // 
            txtKilometers.Location = new Point(336, 94);
            txtKilometers.Name = "txtKilometers";
            txtKilometers.Size = new Size(191, 23);
            txtKilometers.TabIndex = 6;
            txtKilometers.TextChanged += txtKilometers_TextChanged;
            // 
            // BtnConvertToMiles
            // 
            BtnConvertToMiles.Location = new Point(336, 149);
            BtnConvertToMiles.Name = "BtnConvertToMiles";
            BtnConvertToMiles.Size = new Size(191, 81);
            BtnConvertToMiles.TabIndex = 7;
            BtnConvertToMiles.Text = "Convert";
            BtnConvertToMiles.UseVisualStyleBackColor = true;
            BtnConvertToMiles.Click += BtnConvertToMiles_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnConvertToMiles);
            Controls.Add(txtKilometers);
            Controls.Add(lblResult2);
            Controls.Add(lblDisToKilo);
            Controls.Add(lblDisInMiles);
            Controls.Add(txtmiles);
            Controls.Add(lblresult1);
            Controls.Add(btnConvertToKilo);
            Name = "Form1";
            Text = "Distance Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConvertToKilo;
        private Label lblresult1;
        private TextBox txtmiles;
        private Label lblDisInMiles;
        private Label lblDisToKilo;
        private Label lblResult2;
        private TextBox txtKilometers;
        private Button BtnConvertToMiles;
    }
}
