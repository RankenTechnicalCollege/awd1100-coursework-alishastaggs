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
                compScore += 1; //addition instead of concatenation
                lblCompScore.Text = compScore.ToString();
            }
            else
            {
                lblCompPicked.Text = "scissors";
                playerScore += 1; //addition instead of concatenation
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
            Random randGenerator = new Random();
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
            }
            else
            {
                lblCompPicked.Text = "scissors";
            }

            if (randomNum == 1)
            {
                lblPlayerScore.Text += 1;
                lblCompScore.Text += 0;
            }
            else if (randomNum == 2)
            {
                lblPlayerScore.Text += 0;
                lblCompScore.Text += 0;
            }
            else
            {
                lblPlayerScore.Text += 0;
                lblCompScore.Text += 1;
            }

            //if (lblPlayerScore.Text = 3)
            //{
            //    lblResult.Text = "Player Wins!!!";
            //}
            //else if (lblCompScore.Text = 3)
            //{
            //    lblResult.Text = "Computer Wins";
            //}
            //else
            //{
            //    lblResult.Text = "";
            //}
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
            }
            else if (randomNum == 2)
            {
                lblCompPicked.Text = "paper";
            }
            else
            {
                lblCompPicked.Text = "scissors";
            }

            if (randomNum == 1)
            {
                lblPlayerScore.Text += 0; //String Concatenation - meaning adding strings together
                lblCompScore.Text += 1;
            }
            else if (randomNum == 2)
            {
                lblPlayerScore.Text += 1;
                lblCompScore.Text += 0;
            }
            else
            {
                lblPlayerScore.Text += 0;
                lblCompScore.Text += 0;
            }

            //if (lblPlayerScore.Text = 3)
            //{
            //    lblResult.Text = "Player Wins!!!";
            //}
            //else if (lblCompScore.Text = 3)
            //{
            //    lblResult.Text = "Computer Wins";
            //}
            //else
            //{
            //    lblResult.Text = "";
            //}
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
