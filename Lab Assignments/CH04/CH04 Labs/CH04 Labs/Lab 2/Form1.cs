namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal chicken1 = Convert.ToDecimal(txtChicken1.Text);
            decimal chicken2 = Convert.ToDecimal(txtChicken2.Text);
            decimal chicken3 = Convert.ToDecimal(txtChicken3.Text);
            decimal chicken4 = Convert.ToDecimal(txtChicken4.Text);

            decimal totalEggs = chicken1 + chicken2 + chicken3 + chicken4;

            int totalDozen = Convert.ToInt32(totalEggs) / 12;
            int remainingEggs = Convert.ToInt32(totalEggs) % 12;

            lblResult.Text = $"{totalEggs} eggs total, or {totalDozen} dozen and {remainingEggs} eggs.";
        }

        private void txtChicken1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtChicken2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtChicken3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtChicken4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
