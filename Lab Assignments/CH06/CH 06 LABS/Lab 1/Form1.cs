namespace Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            GenerateFortune();
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void GenerateFortune()
        {
            string[] fortunes =
            { "Birthdays are like friends. The more you have the better.",
            "Your smile is a treasure to all who know you.",
            "You never hesitate to tackle the most difficult problems.",
            "The most obvious solution is not always the best.",
            "If you want the rainbow, you will have to tolerate the rain.",
            "The early bird gets the worm, but the second mouse gets the cheese.",
            "From listening comes wisdom and from speaking repentance.",
            "A smile is your personal welcome mat." };

            Random random = new Random();

            int firstFortune = random.Next(fortunes.Length);

            int secondFortune;

            do
            {
                secondFortune = random.Next(fortunes.Length);
            }
            while (secondFortune == firstFortune);

            lblResult.Text = $"{fortunes[firstFortune]}\n{fortunes[secondFortune]}";
        }
    }
}
