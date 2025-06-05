namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtWind_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEstimate_Click(object sender, EventArgs e)
        {
            double wind = Convert.ToDouble(txtWind.Text);

            if (wind >= 157)
            {
                lblResult.Text = "Category 5";
            }
            else if (wind >= 130)
            {
                lblResult.Text = "Category 4";
            }
            else if (wind >= 111)
            {
                lblResult.Text = "Category 3";
            }
            else if (wind >= 96)
            {
                lblResult.Text = "Category 2";
            }
            else if (wind >= 74)
            {
                lblResult.Text = "Category 1";
            }
            else
            {
                lblResult.Text = "Not a hurricane";
            }
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
