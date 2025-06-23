namespace LAB_5
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

        private void btnMask_Click(object sender, EventArgs e)
        {
            string userInput = txtUserInput.Text;
            char[] masked = new char[userInput.Length];
            int unmaskedCount = 0;

            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                if (Char.IsLetterOrDigit(userInput[i]))
                {
                    if (unmaskedCount < 4)
                    {
                        masked[i] = userInput[i];
                        unmaskedCount++;
                    }
                    else
                    {
                        masked[i] = '#';
                    }
                }
                else
                {
                    masked[i] = userInput[i];
                }
            
            }
            lblResult.Text = new string(masked);
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
