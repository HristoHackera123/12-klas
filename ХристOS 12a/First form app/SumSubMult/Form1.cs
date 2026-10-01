namespace SumSubMult
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Error()
        {
            MessageBox.Show("Трябва да смяташ с числа ", "Идиот", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnSum_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = (int.Parse(txtNum1.Text) + int.Parse(txtNum2.Text)).ToString();
            }
            catch
            {
                Error();
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = (int.Parse(txtNum1.Text) - int.Parse(txtNum2.Text)).ToString();
            }
            catch
            {
                Error();
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = (int.Parse(txtNum1.Text) * int.Parse(txtNum2.Text)).ToString();
            }
            catch
            {
                Error();
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {

        }
    }
}
