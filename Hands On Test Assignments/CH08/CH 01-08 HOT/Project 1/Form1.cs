namespace CH_01_08_HOT
{
    public partial class Form1 : Form
    {
        string[] firstName = new string[] { "Markel", "Luiza", "Bryony", "Giraldo", "Lowri" };
        string[] lastName = new string[] { "Diggory", "Gunnar", "Hester", "Addy", "Hari" };
        string[] phoneNum = new string[] { "555-8390", "555-4618", "555-4400", "555-1687", "555-7763" };
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUserInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string userInput = txtUserInput.Text.ToLower();
            bool found = false;

            for (int i = 0; i < firstName.Length; i++)
            {
                if (firstName[i].ToLower().Contains(userInput) || lastName[i].ToLower().Contains(userInput))
                { 
                lblFirstName.Text = firstName[i];
                lblLastName.Text = lastName[i];
                lblPhoneNumber.Text = phoneNum[i];
                found = true;
                    break;
                }
                if (!found)
                {
                    lblFirstName.Text = "error";
                    lblLastName.Text = "error";
                    lblPhoneNumber.Text = "error";
                    lblInvalid.Text = "User Not Found";
                }
            }
        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void lblPhoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblInvalid_Click(object sender, EventArgs e)
        {

        }
    }
}
