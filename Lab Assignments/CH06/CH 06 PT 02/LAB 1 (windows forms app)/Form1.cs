namespace LAB_1__windows_forms_app_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNum3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNum4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtNum1.Text);
            int num2 = Convert.ToInt32(txtNum2.Text);
            int num3 = Convert.ToInt32(txtNum3.Text);
            int num4 = Convert.ToInt32(txtNum4.Text);

            Reverse4(ref num1, ref num2, ref num3, ref num4);

            lblResult.Text = $"{num1}, {num2}, {num3}, {num4}";
        }

        private void Reverse4(ref int num1, ref int num2, ref int num3, ref int num4)
        {
            int temp1 = num1;
            int temp2 = num2;
            int temp3 = num3;
            int temp4 = num4;

            num1 = temp4;
            num2 = temp3;
            num3 = temp2;
            num4 = temp1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
