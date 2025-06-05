namespace Lab_3
{
    public partial class Form1 : Form
    {
        int playerScore = 0;
        int compScore = 0;

        Random randGenerator = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRock_Click(object sender, EventArgs e)
        {
            int randomNum = randGenerator.Next(1, 4);

            int rock = 1;
            int paper = 2;
            int scissors = 3;

            if (randomNum == 1)
            {
                lblCompPicked.Text = "rock";
                
            }
            else if (randomNum == 2)
            {
                lblCompPicked.Text = "paper";
                compScore += 1;
                lblCompScore.Text = compScore.ToString();
            }
            else
            {
                lblCompPicked.Text = "scissors";
                playerScore += 1;
                lblPlayerScore.Text = playerScore.ToString();
            }

            if (lblPlayerScore.Text == "3")
            {
                lblResult.Text = "Player Wins!!!";
            }
            else if (lblCompScore.Text == "3")
            {
                lblResult.Text = "Computer Wins";
            }
            else
            {
                lblResult.Text = "";
            }
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            int randomNum = randGenerator.Next(1, 4);

            int rock = 1;
            int paper = 2;
            int scissors = 3;

            if (randomNum == 1)
            {
                lblCompPicked.Text = "rock";
                playerScore += 1;
                lblPlayerScore.Text = playerScore.ToString();
            }
            else if (randomNum == 2)
            {
                lblCompPicked.Text = "paper";
            }
            else
            {
                lblCompPicked.Text = "scissors";
                compScore += 1;
                lblCompScore.Text = compScore.ToString();
            }

            if (lblPlayerScore.Text == "3")
            {
                lblResult.Text = "Player Wins!!!";
            }
            else if (lblCompScore.Text == "3")
            {
                lblResult.Text = "Computer Wins";
            }
            else
            {
                lblResult.Text = "";
            }
            }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            Random randGenerator = new Random();
            int randomNum = randGenerator.Next(1, 4);

            int rock = 1;
            int paper = 2;
            int scissors = 3;

            if (randomNum == 1)
            {
                lblCompPicked.Text = "rock";
                compScore += 1;
                lblCompScore.Text = compScore.ToString();
            }
            else if (randomNum == 2)
            {
                lblCompPicked.Text = "paper";
                playerScore += 1;
                lblPlayerScore.Text = playerScore.ToString();
            }
            else
            {
                lblCompPicked.Text = "scissors";
            }

            if (lblPlayerScore.Text == "3")
            {
                lblResult.Text = "Player Wins!!!";
            }
            else if (lblCompScore.Text == "3")
            {
                lblResult.Text = "Computer Wins";
            }
            else
            {
                lblResult.Text = "";
            }
            }

        private void lblCompPicked_Click(object sender, EventArgs e)
        {

        }

        private void lblPlayerScore_Click(object sender, EventArgs e)
        {

        }

        private void lblCompScore_Click(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
