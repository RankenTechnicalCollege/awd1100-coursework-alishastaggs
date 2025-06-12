using System;
using System.Diagnostics.Eventing.Reader;

namespace Exercise_3
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

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //USER INPUT
            string enteredLength = txtLength.Text;
            int length;
            int.TryParse(enteredLength, out length);

            string enteredWidth = txtWidth.Text;
            int width;
            int.TryParse(enteredWidth, out width);

            //AREA
            double area = length * width;
            lblArea.Text = $"{Convert.ToString(area)} sq feet";

            //WEEKLY FEE AND TOTAL COST
            int fee1 = 50;
            int fee2 = 35;
            int fee3 = 25;

            if (area >= 600)
            {
                lblWeeklyFee.Text = $"${Convert.ToString(fee1)}";
                lblTotalCost.Text = $"{fee1 * 20:C}";
            }
            else if (area >= 400 && area < 600)
            {
                lblWeeklyFee.Text = $"${Convert.ToString(fee2)}";
                lblTotalCost.Text = $"{fee2 * 20:C}";
            }
            else if (area > 0 && area < 400)
            {
                lblWeeklyFee.Text = $"${Convert.ToString(fee3)}";
                lblTotalCost.Text = $"{fee3 * 20:C}";
            }
            else
            {
                lblWeeklyFee.Text = "please enter valid information";
            }
        }

        private void lblArea_Click(object sender, EventArgs e)
        {

        }

        private void lblWeeklyFee_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalCost_Click(object sender, EventArgs e)
        {

        }
    }
}
