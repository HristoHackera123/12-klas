namespace FormColorPicker
{
    public partial class Form1 : Form
    {
        Dictionary<int, Color> colorNames = new Dictionary<int, Color>();
        string currentCol = "default";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            colorNames.Add(0, Color.Red);
            colorNames.Add(1, Color.Blue);
            colorNames.Add(2, Color.Green);
            colorNames.Add(3, Color.Yellow);
            colorNames.Add(4, Color.Black);
            colorNames.Add(5, Color.White);
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show($"Are you sure you wanna change to {lsbColors.SelectedItem.ToString()}?", "Question", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                this.BackColor = colorNames[lsbColors.SelectedIndex];
                currentCol = lsbColors.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show($"Chose to stay at {currentCol}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdd.Text) || lsbColors.Items.Contains(txtAdd.Text))
            {
                MessageBox.Show("Need an untaken name for color");
                return;
            }

            DialogResult res = colorDialog.ShowDialog();

            if (res == DialogResult.OK)
            {
                lsbColors.Items.Add(txtAdd.Text);
                colorNames.Add(lsbColors.Items.Count-1, colorDialog.Color);
            }
        }
    }
}
