namespace LAB_2
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
            float gpa;
            int testScore;

            if (float.TryParse(txtScore.Text, out gpa) && int.TryParse(txtScore.Text, out testScore))
            {
                bool accept = IsStudentAccepted(gpa, testScore);

                if (accept)
                {
                    lblResult.Text = "Accept";
                }
                else
                {
                    lblResult.Text = "Reject";
                }
            
            }
            else
            {
                lblResult.Text = "Invalid Input";
            }

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private bool IsStudentAccepted(float gpa, int testScore)
        { 
            if (gpa >= 3.0 && testScore >= 60)
            {
                return true;
            }
            else if (gpa < 3.0 && testScore > 80)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
