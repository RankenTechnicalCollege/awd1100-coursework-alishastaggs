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
            double inches = Convert.ToDouble(txtInches.Text);

            double result = inches * cmPerIn;

            //error msg (I thought this would have worked with charcters but I can not figure out how to do that.)
            //(this is my best shot at error handling)

            if (inches <= 9999999999999999999)
            {
                lblResult.Text = Convert.ToString($"{inches} inches is {result} centimeters");
            }

            else
            {
                lblResult.Text = "Please enter a positive number";
            }
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
