namespace LAB_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUserInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string input = txtUserInput.Text;
            int vowelCount = CountVowels(input);
            lblResult.Text = $"{vowelCount}";
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private int CountVowels(string phrase)
        {
            int count = 0;
            string vowels = "aeiouAEIOU";

            foreach (char c in phrase)
            {
                if (vowels.Contains(c))
                { 
                count++;
                }
            }

            return count;
        }
    }
}
