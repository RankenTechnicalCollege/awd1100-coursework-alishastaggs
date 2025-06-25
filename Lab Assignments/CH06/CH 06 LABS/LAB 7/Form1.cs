namespace LAB_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<string> accountNumbers = new List<string>() { "12345", "67890"};
        private List<string> names = new List<string>() { "Sam", "Zora" };
        private List<string> pins = new List<string> { "1111", "2222" };
        private List<decimal> balances = new List<decimal> { 500.00m, 1000.00m };
        private int loggedInIndex = -1;

        private void txtAccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login(txtAccount.Text, txtPin.Text);
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void txtDeposit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWithdrawal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtDeposit.Text, out decimal amount))
            {
                MakeDeposit(amount);
            }
            else
            {
                lblWelcome.Text = "Invalid deposit amount.";
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtWithdrawal.Text, out decimal amount))
            {
                MakeWithdrawl(amount);
            }
            else
            {
                lblWelcome.Text = "Invalid withdrawl amount.";
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }




        //METHODS




        private void Login(string accountNum, string pin)
        { 
        int index = accountNumbers.IndexOf(accountNum);
            if (index != -1 && pins[index] == pin)
            {
                loggedInIndex = index;
                lblWelcome.Text = $"Welcome {names[index]}\nyour account balance is {balances[index]:F2}";
            }
            else
            {
                Logout();
                lblWelcome.Text = "Login failed";
            }
        }
        private void Logout()
        {
            loggedInIndex = -1;
            lblWelcome.Text = "Logged out";
        }

        private void MakeDeposit(decimal depositAmount)
        {
            if (loggedInIndex != -1)
            {
                balances[loggedInIndex] += depositAmount;
                lblWelcome.Text = $"\n Your account balance is {balances[loggedInIndex]:F2}";
            }
            else
            {
                lblWelcome.Text = "Please log in first";
            }
        }

        private void MakeWithdrawl(decimal withdrawalAmount)
        {
            if (loggedInIndex != -1)
            {
                if (withdrawalAmount <= balances[loggedInIndex])
                {
                    balances[loggedInIndex] -= withdrawalAmount;
                    lblWelcome.Text = $"\n Your account balance is {balances[loggedInIndex]:F2}";
                }
                else
                {
                    lblWelcome.Text = "insufficient funds";
                }
            }
            else
            {
                lblWelcome.Text = "Please log in first";
            }
        }

    }
}
