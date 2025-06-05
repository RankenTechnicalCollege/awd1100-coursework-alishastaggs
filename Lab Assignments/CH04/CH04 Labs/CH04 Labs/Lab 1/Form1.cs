namespace Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtmiles_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConvertToKilo_Click(object sender, EventArgs e)
        {
            string miles = txtmiles.Text;
            decimal num1 = 1.6m;
            decimal result = Convert.ToDecimal(miles) * num1;
            lblresult1.Text = $"{miles} miles is equal to {Convert.ToString(result)} kilometers.";
        }

        private void lblresult1_Click(object sender, EventArgs e)
        {

        }











        private void lblDisToKilo_Click(object sender, EventArgs e)
        {

        }

        private void txtKilometers_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnConvertToMiles_Click(object sender, EventArgs e)
        {
            string kilometers = txtKilometers.Text;
            decimal num1 = 1.6m;
            decimal result = Convert.ToDecimal(kilometers) / num1;
            lblResult2.Text = $"{kilometers} kilometers is equal to {Convert.ToString(result)} miles.";
        }

        private void lblResult2_Click(object sender, EventArgs e)
        {

        }
    }
}
