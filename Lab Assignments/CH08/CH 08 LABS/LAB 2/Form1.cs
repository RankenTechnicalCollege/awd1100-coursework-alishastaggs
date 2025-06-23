namespace LAB_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNights_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int[] nightlyRate = { 200, 180, 160, 145 };
            int[] minNights = { 1, 3, 5, 8 };
            int[] maxNights = { 2, 4, 7, int.MaxValue };


            if (int.TryParse(txtNights.Text, out int userNights) && userNights > 0)
            {

                for (int i = 0; i < minNights.Length; i++)
                {
                    if (userNights >= minNights[i] && userNights <= maxNights[i])
                    { 
                    int rate = nightlyRate[i];
                    int total = userNights * rate;

                        lblNightlyCost.Text = $"{rate:C}";
                        lblTotal.Text = $"{total:C}";
                        return;
                    }
                }
            }
            else
            {
                lblNightlyCost.Text = "invalid input";
                lblTotal.Text = "";
            }
        }

        private void lblNightlyCost_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
