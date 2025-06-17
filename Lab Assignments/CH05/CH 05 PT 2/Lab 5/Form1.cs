namespace Lab_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtPhrase_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string phrase = txtPhrase.Text;
            int vowelCount = 0;

            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase[i] == 'a')
                {
                    vowelCount++;
                }
                if (phrase[i] == 'e')
                {
                    vowelCount++;
                }
                if (phrase[i] == 'i')
                {
                    vowelCount++;
                }
                if (phrase[i] == 'o')
                {
                    vowelCount++;
                }
                if (phrase[i] == 'u')
                {
                    vowelCount++;
                }
                if (phrase[i] == 'A')
                {
                    vowelCount++;
                }
                if (phrase[i] == 'E')
                {
                    vowelCount++;
                }
                if (phrase[i] == 'I')
                {
                    vowelCount++;
                }
                if (phrase[i] == 'O')
                {
                    vowelCount++;
                }
                if (phrase[i] == 'U')
                {
                    vowelCount++;
                }
            }

            lblVowels.Text = $"there are {vowelCount} vowels in your phrase.";

        }

        private void lblVowels_Click(object sender, EventArgs e)
        {

        }
    }
}
