namespace Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtGpa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtScore_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            double gpa = Convert.ToDouble(txtGpa.Text);
            double testScore = Convert.ToDouble(txtScore.Text);

            if (gpa >= 3.0 && testScore >= 60)
            {
                lblResult.Text = $"Accept";
            }
            else if (gpa < 3.0 && testScore >= 80)
            {
                lblResult.Text = $"Accept";
            }
            else
            {
                lblResult.Text = $"Reject";
            }
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
