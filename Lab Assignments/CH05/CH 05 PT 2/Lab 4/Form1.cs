namespace Lab_4
{
    public partial class Form1 : Form
    {
        decimal dSum = 0;
        decimal eSum = 0;
        decimal fSum = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSales_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDanielle_Click(object sender, EventArgs e)
        {
            decimal sales;

            if (decimal.TryParse(txtSales.Text, out sales))
            {
                if (sales != 999)
                {
                    dSum += sales;
                    lblDanielle.Text = $"Danielle Sales: {dSum:C}";
                    txtSales.Clear();
                }
                else
                {
                    lblDanielle.Text = $"Danielle Sales: {dSum:C} - input ended";
                    txtSales.Clear();
                }
            }
            else
            {
                lblDanielle.Text = "enter valid number";
            }
            decimal total = dSum + eSum + fSum;
            lblTotal.Text = $"Grand Total: {total:C}";

            if (dSum > eSum && dSum > fSum)
            {
                lblMostSales.Text = "Danielle has the most sales";
            }
        }

        private void btnEdward_Click(object sender, EventArgs e)
        {
            decimal sales;

            if (decimal.TryParse(txtSales.Text, out sales))
            {
                if (sales != 999)
                {
                    eSum += sales;
                    lblEdward.Text = $"Edward Sales: {eSum:C}";
                    txtSales.Clear();
                }
                else
                {
                    lblEdward.Text = $"Edward Sales: {eSum:C} - input ended";
                    txtSales.Clear();
                }
            }
            else
            {
                lblEdward.Text = "enter valid number";
            }
            decimal total = dSum + eSum + fSum;
            lblTotal.Text = $"Grand Total: {total:C}";

            if (eSum > dSum && eSum > fSum)
            {
                lblMostSales.Text = "Edward has the most sales";
            }
        }

        private void btnFrancis_Click(object sender, EventArgs e)
        {
            decimal sales;

            if (decimal.TryParse(txtSales.Text, out sales))
            {
                if (sales != 999)
                {
                    fSum += sales;
                    lblFrancis.Text = $"Francis Sales: {fSum:C}";
                    txtSales.Clear();
                }
                else
                {
                    lblFrancis.Text = $"Francis Sales: {fSum:C} - input ended";
                    txtSales.Clear();
                }
            }
            else
            {
                lblFrancis.Text = "enter valid number";
            }
            decimal total = dSum + eSum + fSum;
            lblTotal.Text = $"Grand Total: {total:C}";

            if (fSum > eSum && fSum > dSum)
            {
                lblMostSales.Text = "Francis has the most sales";
            }
        }

        private void lblDanielle_Click(object sender, EventArgs e)
        {

        }

        private void lblEdward_Click(object sender, EventArgs e)
        {

        }

        private void lblFrancis_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblMostSales_Click(object sender, EventArgs e)
        {

        }
    }
}
