namespace LAB_4
{
    public partial class MovieDatabase : Form
    {
        string[] name = new string[] { "Lord of the Rings: Fellowship of the Ring", "Jaws", "The Conjuring" };
        string[] director = new string[] { "Peter Jackson", "Steven Spielberg", "James Wan" };
        string[] description = new string[] { "An epic journey of hobits and magic", "a suspenseful thriller about a great white shark that terrorizes a beach town, forcing a police chief, a marine biologist, and a shark hunter to team up and stop it.", "A family is haunted by the supernatural" };

        public MovieDatabase()
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

            for (int i = 0; i < name.Length; i++)
            {
                if (name[i].ToLower().Contains(userInput) || director[i].ToLower().Contains(userInput))
                { 
                lblName.Text = name[i];
                lblDescription.Text = description[i];
                lblDirector.Text = director[i];
                    found = true;
                    break;
                }
                if (!found)
                {
                    lblDescription.Text = "Movie Not Found";
                    lblDirector.Text = "Movie Not Found";
                    lblName.Text = "Movie Not Found";
                }
                
            }
            
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblDirector_Click(object sender, EventArgs e)
        {

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }
    }
}
