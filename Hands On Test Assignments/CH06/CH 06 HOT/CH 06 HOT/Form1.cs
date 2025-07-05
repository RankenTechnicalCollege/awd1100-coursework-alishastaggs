using System.Windows.Forms.Design;

namespace CH_06_HOT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<string> name = new List<string>() { "The Great Gatsby", "War and Peace", "Moby-Dick", "Hamlet", "Pride and Prejudice" };
        private List<string> description = new List<string>() { "The story of eccentric millionaire Jay Gatsby and his pursuit of his lost love.",
        "A fictional story about the 1812 French invasion of Russia.", "The story of a sailor’s relentless hunt for a white whale.",
        "A Shakespearean tragedy about a young man coming home from college after the murder of his father.", "A comedic story of love and life in Old England."};
        private List<string> Author = new List<string>() { "F. Scott Fitzgerald", "Leo Tolstoy", "Herman Melville", "William Shakespeare", "Jane Austen" };
        private List<string> isbn = new List<string>() { "978-1847496140", "978-1400079988", "978-1503280786", "978-1973844402", "978-0141439518" };

        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
        SearchByAuthor(txtAuthor.Text);
        }

        private void btnISBN_Click(object sender, EventArgs e)
        {
        SearchByIsbn(txtISBN.Text);
        }

        private void btnKeyword_Click(object sender, EventArgs e)
        {
        SearchByKeyword(txtKeyword.Text);
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void lblAuthor_Click(object sender, EventArgs e)
        {
            
        }

        private void lblISBN_Click(object sender, EventArgs e)
        {

        }

        private void SearchByIsbn(string isbnNumber)
        {
            int index = isbn.IndexOf(isbnNumber);
            bool found = false;

            for (int i = 0; i < isbn.Count; i++)
            {
                if (isbn[i].Contains(isbnNumber))
                {
                    lblAuthor.Text = Author[i];
                    lblISBN.Text = isbn[i];
                    lblName.Text = name[i];
                    lblDescription.Text = description[i];
                    found = true;
                    break;
                }
                if (!found)
                {
                    lblDescription.Text = "Item not found";
                    lblName.Text = "Item not found";
                    lblISBN.Text = "Item not found";
                    lblAuthor.Text = "Item not found";
                }
            }
        }

        private void SearchByAuthor(string userAuthor)
        {
            int index = Author.IndexOf(userAuthor);
        bool found = false;

            for (int i = 0; i < txtAuthor.Text.Length; i++)
            {
                if (Author[i].ToLower().Contains(userAuthor.ToLower()))
                { 
                lblAuthor.Text = Author[i];
                lblISBN.Text = isbn[i];
                lblName.Text = name[i];
                lblDescription.Text = description[i];
                    found = true;
                    break;
                }
                if (!found)
                {
                    lblDescription.Text = "Item not found";
                    lblName.Text = "Item not found";
                    lblISBN.Text = "Item not found";
                    lblAuthor.Text = "Item not found";
                }
            }
        }

        private void SearchByKeyword(string keyword)
        {
            bool found = false;

            for (int i = 0; i < description.Count; i++)
            {
                if (description[i].ToLower().Contains(keyword.ToLower()) || name[i].ToLower().Contains(keyword.ToLower()))
                {
                    lblAuthor.Text = Author[i];
                    lblISBN.Text = isbn[i];
                    lblName.Text = name[i];
                    lblDescription.Text = description[i];
                    found = true;
                    break;
                }
                if (!found)
                {
                    lblDescription.Text = "Item not found";
                    lblName.Text = "Item not found";
                    lblISBN.Text = "Item not found";
                    lblAuthor.Text = "Item not found";
                }
            }
        }
    }
}
