namespace LibraryInput
{
    public partial class Form1 : Form
    {
        bool error = true;
        List<Control> controlList = new List<Control>();
        string errorText = "Грешка при въвеждане\nМоля подайте данни за: автор, заглавие, жанр, корица, издателство";
        public Form1()
        {
            InitializeComponent();
        }
        private void ControlHasText(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (!string.IsNullOrEmpty(control.Text))
            {
                
                if(!controlList.Contains(control))
                {
                    controlList.Add(control);
                }
                if(controlList.Count == 5)
                {
                    error = false;
                }
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtAuthor.Text))
            //{
            //    errorText += " авторa,";
            //    error = true;
            //}
            //if (string.IsNullOrEmpty(txtTitle.Text))
            //{
            //    errorText += " заглавието,";
            //    error = true;
            //}
            //if (string.IsNullOrEmpty(cmbIzdatelstvo.SelectedText))
            //{
            //    errorText += " издателството,";
            //    error = true;

            //}
            //if (string.IsNullOrEmpty(cmbGenre.SelectedText))
            //{
            //    errorText += " жанра,";
            //    error = true;
            //}
            //if (string.IsNullOrEmpty(cmbCover.SelectedText))
            //{
            //    errorText += " вида на корицата,";
            //    error = true;
            //}
            if (error)
            {
                MessageBox.Show(errorText.TrimEnd(','), "Неуспешно въвеждане");

            }
            else
            {
                MessageBox.Show(
                $"Вие въведохте {txtTitle.Text} с автор {txtAuthor.Text}, " +
                $"жанр {cmbGenre.SelectedText} с вид на корицата {cmbCover.SelectedText} от издателство {cmbIzdatelstvo.SelectedText}." +
                $"Подвърждавате ли?", "Успешно въвеждане", MessageBoxButtons.YesNo);
                if(DialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Данните са успешно въведени!");
                    txtAuthor.Clear();
                    txtTitle.Clear();
                    cmbCover.SelectedIndex = -1;
                    cmbGenre.SelectedIndex = -1;
                    cmbIzdatelstvo.SelectedIndex = -1;
                }
            }
        }
    }
}
