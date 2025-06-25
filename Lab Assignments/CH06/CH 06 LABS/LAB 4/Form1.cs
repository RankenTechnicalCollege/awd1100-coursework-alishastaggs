namespace LAB_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int length = Convert.ToInt32(txtLength.Text);
            int width = Convert.ToInt32(txtWidth.Text);
            lblArea.Text = $"{CalculateTotalArea(length, width)}";
            int totalArea = CalculateTotalArea (length, width);
            lblTotalCost.Text = $"{CalculatePaintEstimate(totalArea):C}";
        }

        private void lblArea_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalCost_Click(object sender, EventArgs e)
        {

        }

        private int CalculateTotalArea(int length, int width)
        {
            int height = 9;
            int totalArea = 0;
            totalArea = (length * height * 2) + (width * height * 2);
            return totalArea;
        }

        private double CalculatePaintEstimate(int totalArea)
        {
            int perSF = 6;
            int estimate = perSF * totalArea;
            return estimate;
        }
    }
}
