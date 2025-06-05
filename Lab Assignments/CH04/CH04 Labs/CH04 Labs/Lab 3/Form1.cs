namespace Lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // user input name
            string emp1 = txtEmp1.Text;
            lblEmp1.Text = emp1;

            string emp2 = txtEmp2.Text;
            lblEmp2.Text = emp2;

            string emp3 = txtEmp3.Text;
            lblEmp3.Text = emp3;

            // user input salary
            decimal salaryEmp1 = Convert.ToDecimal(txtSalary1.Text);
            lblEmp1Sal2025.Text = $"{salaryEmp1:C}";

            decimal salaryEmp2 = Convert.ToDecimal(txtSalary2.Text);
            lblEmp2Sal2025.Text = $"{salaryEmp2:C}";

            decimal salaryEmp3 = Convert.ToDecimal(txtSalary3.Text);
            lblEmp3Sal2025.Text = $"{salaryEmp3:C}";

            // variable
            decimal num1 = 0.04m;

            // 2026
            decimal SalaryEmp1Year2026 = (salaryEmp1 * num1) + salaryEmp1;
            lblEmp1Year2026.Text = $"{SalaryEmp1Year2026:C}";

            decimal SalaryEmp2Year2026 = (salaryEmp2 * num1) + salaryEmp2;
            lblEmp2Year2026.Text = $"{SalaryEmp2Year2026:C}";

            decimal SalaryEmp3Year2026 = (salaryEmp3 * num1) + salaryEmp3;
            lblEmp3Year2026.Text = $"{SalaryEmp3Year2026:C}";

            //2027
            decimal SalaryEmp1Year2027 = (SalaryEmp1Year2026 * num1) + SalaryEmp1Year2026;
            lblEmp1Year2027.Text = $"{SalaryEmp1Year2027:C}";

            decimal SalaryEmp2Year2027 = (SalaryEmp2Year2026 * num1) + SalaryEmp2Year2026;
            lblEmp2Year2027.Text = $"{SalaryEmp2Year2027:C}";

            decimal SalaryEmp3Year2027 = (SalaryEmp3Year2026 * num1) + SalaryEmp3Year2026;
            lblEmp3Year2027.Text = $"{SalaryEmp3Year2027:C}";

        }

        private void lblEmp1_Click(object sender, EventArgs e)
        {

        }

        private void lblEmp2_Click(object sender, EventArgs e)
        {

        }

        private void lblEmp3_Click(object sender, EventArgs e)
        {

        }

        private void txtEmp1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmp2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmp3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmp1Sal2025_Click(object sender, EventArgs e)
        {

        }

        private void lblEmp2Sal2025_Click(object sender, EventArgs e)
        {

        }

        private void lblEmp3Sal2025_Click(object sender, EventArgs e)
        {

        }

        private void txtSalary1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalary2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalary3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmp1Year2026_Click(object sender, EventArgs e)
        {

        }

        private void lblEmp2Year2026_Click(object sender, EventArgs e)
        {

        }

        private void lblEmp3Year2026_Click(object sender, EventArgs e)
        {

        }
    }
}
