namespace Exercise_1
{
    public partial class Form1 : Form
    {
        double cmPerIn = 2.54;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtInches_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string enteredInches = txtInches.Text;

            double inches;

            double.TryParse(enteredInches, out inches);

            double result = inches * cmPerIn;

            if (inches <= 0)
            {
                lblResult.Text = "Please enter a positive number";
            }
            else
            {
                    lblResult.Text = Convert.ToString($"{inches} inches is {result} centimeters");
            }
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
