using System.Windows.Forms.Design;

namespace CH_06_HOT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<string> name = new List<string>() { "The Great Gatsby", "War and Peace", "Moby-Dick", "Hamlet", "Pride and Prejduice" };
        private List<string> description = new List<string>() { "The story of eccentric millionaire Jay Gatsby and his pursuit of his lost love.",
        "A fictional story about the 1812 French invasion of Russia.", "The story of a sailor’s relentless hunt for a white whale.",
        "A Shakespearean tragedy about a young man coming home from college after the murder of his father.", "A comedic story of love and life in Old England."};
        private List<string> Author = new List<string>() { "F. Scott Fitzgerald", "Leo Tolstoy", "Herman Melville", "William Shakespeare", "Jane Austen" };
        private List<string> ISBN = new List<string>() { "978-1847496140", "978-1400079988", "978-1503280786", "978-1973844402", "978-0141439518" };

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

        }

        private void btnISBN_Click(object sender, EventArgs e)
        {

        }

        private void btnKeyword_Click(object sender, EventArgs e)
        {

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
    }
}
