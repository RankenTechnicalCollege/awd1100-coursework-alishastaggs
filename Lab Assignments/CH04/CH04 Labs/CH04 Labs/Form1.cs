namespace CH04_Labs
{
    public partial class DistanceConverter : Form
    {
        public DistanceConverter()
        {
            InitializeComponent(GetBtnMiles());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMiles_TextChanged(object sender, EventArgs e)
        {
            int miles = Convert.ToInt32(Console.ReadLine());
            double resultKilometers = miles * 1.6;
        }

        private void lblKilometers_Click(object sender, EventArgs e)
        {

        }

        private void btnKilometers_Click(object sender, EventArgs e)
        {

        }
    }
}
