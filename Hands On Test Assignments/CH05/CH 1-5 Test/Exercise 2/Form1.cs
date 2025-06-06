namespace Exercise_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtGpa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double gpa = Convert.ToDouble(txtGpa.Text);

            if (4.0 >= gpa && gpa > 3.0)
            {
                lblGrade.Text = "A";
            }
            else if (3.0 >= gpa && gpa > 2.0)
            {
                lblGrade.Text = "B";
            }
            else if (2.0 >= gpa && gpa > 1.0)
            {
                lblGrade.Text = "C";
            }
            else if (1.0 >= gpa && gpa > 0)
            {
                lblGrade.Text = "D";
            }
            else if (gpa == 0)
            {
                lblGrade.Text = "F";
            }
            else
            {
                lblGrade.Text = "Please input valid number";
            }
        }

        private void lblGrade_Click(object sender, EventArgs e)
        {

        }
    }
}
