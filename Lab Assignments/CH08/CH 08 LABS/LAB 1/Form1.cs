namespace LAB_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtZip_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int[] zip = { 63101, 63103, 63105, 63109, 63113, 63130, 63133, 63163, 63137 };
            int[] charges = { 20, 12, 25, 15, 10, 23, 18, 20, 17, 12 };

            int userZip;

            if (int.TryParse(txtZip.Text, out userZip))
            {
                bool found = false;

                for (int i = 0; i < zip.Length; i++)
                {
                    if (zip[i] == userZip)
                    {
                        lblResult.Text = $"Delivery charge for {userZip} is {charges[i]}";
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    lblResult.Text = "Zip code not found.";
                }
            }
            else
            {
                lblResult.Text = "Please enter a valid zip code.";
            }
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
