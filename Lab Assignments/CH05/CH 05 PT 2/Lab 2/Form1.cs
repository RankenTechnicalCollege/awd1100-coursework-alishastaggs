namespace Lab_2
{
    public partial class Form1 : Form
    {
        double sum = 0;
        double numberOfScores = 0;
        double average = 0;
        double lowest = int.MaxValue;
        double highest = int.MinValue;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtScore_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            if (double.TryParse(txtScore.Text, out double testScore))
            {
                if (testScore == 999)
                {
                        lblNumOfScores.Text = $"Number of scores enntered: {numberOfScores}";
                        lblSum.Text = $"Sum of test scores: {sum}";
                        lblAverage.Text = $"Average test score: {average}";
                        lblLowest.Text = $"Lowest test score: {lowest}";
                        lblHighest.Text = $"Highest test score: {highest}";

                        txtScore.Clear();
                    return;
                }
                if (testScore < 0 || testScore > 100)
                {
                    lblNumOfScores.Text = "Please enter a number between 0 and 100";
                    return;
                }
                if (testScore < lowest)
                {
                    lowest = testScore;
                }
                if (testScore > highest)
                {
                    highest = testScore;
                }

                sum = sum + testScore;
                numberOfScores++;
                average = sum / numberOfScores;

                txtScore.Clear();
            }
            else
            {
                lblNumOfScores.Text = "Enter a number 0-100";
            }
        }

        private void lblNumOfScores_Click(object sender, EventArgs e)
        {

        }

        private void lblSum_Click(object sender, EventArgs e)
        {

        }

        private void lblAverage_Click(object sender, EventArgs e)
        {

        }

        private void lblLowest_Click(object sender, EventArgs e)
        {

        }

        private void lblHighest_Click(object sender, EventArgs e)
        {

        }
    }
}
