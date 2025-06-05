namespace CH04_Labs
{
    partial class DistanceConverter
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

        private Button GetBtnMiles()
        {
            return btnMiles;
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(Button btnMiles)
        {
            lblMiles = new Label();
            lblKilometers = new Label();
            txtMiles = new TextBox();
            txtKilometers = new TextBox();
            btnKilometers = new Button();
            btnMiles = new Button();
            lblResult1 = new Label();
            lblResult2 = new Label();
            SuspendLayout();
            // 
            // lblMiles
            // 
            lblMiles.AutoSize = true;
            lblMiles.Font = new Font("Yu Gothic Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMiles.Location = new Point(77, 39);
            lblMiles.Margin = new Padding(6, 0, 6, 0);
            lblMiles.Name = "lblMiles";
            lblMiles.Size = new Size(219, 31);
            lblMiles.TabIndex = 0;
            lblMiles.Text = "Distance in miles";
            lblMiles.TextAlign = ContentAlignment.MiddleCenter;
            lblMiles.Click += label1_Click;
            // 
            // lblKilometers
            // 
            lblKilometers.AutoSize = true;
            lblKilometers.Font = new Font("Yu Gothic Medium", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKilometers.Location = new Point(439, 40);
            lblKilometers.Name = "lblKilometers";
            lblKilometers.Size = new Size(273, 30);
            lblKilometers.TabIndex = 1;
            lblKilometers.Text = "Distance in kilometers";
            lblKilometers.Click += lblKilometers_Click;
            // 
            // txtMiles
            // 
            txtMiles.Location = new Point(77, 100);
            txtMiles.Name = "txtMiles";
            txtMiles.Size = new Size(219, 23);
            txtMiles.TabIndex = 2;
            txtMiles.TextChanged += txtMiles_TextChanged;
            // 
            // txtKilometers
            // 
            txtKilometers.Location = new Point(461, 100);
            txtKilometers.Name = "txtKilometers";
            txtKilometers.Size = new Size(219, 23);
            txtKilometers.TabIndex = 3;
            // 
            // btnKilometers
            // 
            btnKilometers.Location = new Point(77, 149);
            btnKilometers.Name = "btnKilometers";
            btnKilometers.Size = new Size(219, 99);
            btnKilometers.TabIndex = 4;
            btnKilometers.Text = "Convert to km";
            btnKilometers.UseVisualStyleBackColor = true;
            btnKilometers.Click += btnKilometers_Click;
            // 
            // btnMiles
            // 
            btnMiles.Location = new Point(461, 149);
            btnMiles.Name = "btnMiles";
            btnMiles.Size = new Size(219, 99);
            btnMiles.TabIndex = 5;
            btnMiles.Text = "Convert to miles";
            btnMiles.UseMnemonic = false;
            btnMiles.UseVisualStyleBackColor = true;
            btnMiles.Click += button2_Click;
            // 
            // lblResult1
            // 
            lblResult1.AutoSize = true;
            lblResult1.Location = new Point(77, 329);
            lblResult1.Name = "lblResult1";
            lblResult1.Size = new Size(0, 15);
            lblResult1.TabIndex = 6;
            // 
            // lblResult2
            // 
            lblResult2.AutoSize = true;
            lblResult2.Location = new Point(461, 329);
            lblResult2.Name = "lblResult2";
            lblResult2.Size = new Size(0, 15);
            lblResult2.TabIndex = 7;
            // 
            // DistanceConverter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult2);
            Controls.Add(lblResult1);
            Controls.Add(btnMiles);
            Controls.Add(btnKilometers);
            Controls.Add(txtKilometers);
            Controls.Add(txtMiles);
            Controls.Add(lblKilometers);
            Controls.Add(lblMiles);
            Name = "DistanceConverter";
            Text = "Distance_Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMiles;
        private Label lblKilometers;
        private TextBox txtMiles;
        private TextBox txtKilometers;
        private Button btnKilometers;
        private Button btnMiles;
        private Label lblResult1;
        private Label lblResult2;
    }
}
