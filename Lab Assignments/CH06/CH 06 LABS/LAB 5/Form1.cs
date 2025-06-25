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
            string input = txtUserInput.Text;
            string masked = MaskNumber(input, '#', 4);
            lblResult.Text = masked;
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private string MaskNumber(string unmaskedCC, char replacementChar, int numDigitsToPreserve)
        { 
        int digitsCount = 0;

            for (int i = unmaskedCC.Length - 1; i >= 0 && digitsCount < numDigitsToPreserve; i--)
            {
                if (Char.IsDigit(unmaskedCC[i]))
                { 
                digitsCount++;
                }
            }

            string result = "";
            int digitsSeen = 0;

            for (int i = unmaskedCC.Length - 1; i >= 0; i--)
            { 
            char c = unmaskedCC[i];
                if (Char.IsDigit(c) || Char.IsLetter(c))
                {
                    if (digitsSeen < numDigitsToPreserve && Char.IsDigit(c))
                    {
                        result = c + result;
                        digitsSeen++;
                    }
                    else
                    {
                        result = replacementChar + result;
                    }
                }
                else 
                {
                    result = c + result;
                }
            }
            return result;
        }
    }
}
