namespace LAB_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtWood_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDrawers_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEstimate_Click(object sender, EventArgs e)
        {
            string woodType = GetWood();
            int drawers = GetDrawers();

            if (drawers < 0)
            {
                lblDrawers.Text = "Number of drawers cannot be negative.";
                label6.Text = "";
                lblTotalCost.Text = "";
            }

            double totalCost = CalculateTotalCost(woodType, drawers);
            double woodCost = CalculateWoodCost(woodType);
            double drawerCost = CalculateDrawerCost(drawers);

            lblTotalCost.Text = $"{totalCost:C}";
            label6.Text = $"{drawerCost:C}";
            lblCostWood.Text = $"{woodCost:C}";
        }

        private void lblWood_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalCost_Click(object sender, EventArgs e)
        {

        }

        private string GetWood()
        { 
        string input = txtWood.Text.ToLower();
            return input switch
            {
                "m" => "mahogany",
                "o" => "oak",
                "p" => "pine",
            };
        }

        private int GetDrawers()
        { 
        if (int.TryParse(txtDrawers.Text, out int drawers))
                return drawers;
        else return -1;
        }

        private double CalculateWoodCost(string woodType)
        {
            return woodType switch
            {
                "pine" => 100,
                "oak" => 140,
                "mahogany" => 180,
            };
        }

        private double CalculateDrawerCost(int numDrawers)
        {
            return numDrawers * 30;
        }

        private double CalculateTotalCost(string woodType, int numDrawers)
        {
            double baseCost = CalculateWoodCost(woodType);
            double drawerCost = CalculateDrawerCost(numDrawers);
            return baseCost + drawerCost;
        }
    }
}
