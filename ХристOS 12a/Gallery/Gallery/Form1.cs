using Gallery.Properties;

namespace Gallery
{
    public partial class Form1 : Form
    {
        List<Bitmap> imgList = new List<Bitmap>();
        int currentIdx = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            imgList.Add(Resources.son_meme_resize);
            imgList.Add(Resources.evil_and_intimidating_horse_resize);
            imgList.Add(Resources.big_chungus_resize);

            pictureBox.Image = imgList[currentIdx];
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (control.Name == "btnLeft")
            {
                ChangeImage(currentIdx-1);
            }
            else
            {
                ChangeImage(currentIdx+1);
            }
        }
        private void ChangeImage(int set)
        {
            if (set < 0)
            {
                set = imgList.Count - 1;
            }
            else if (set > imgList.Count - 1)
            {
                set = 0;
            }
            pictureBox.Image = imgList[set];
            currentIdx = set;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addFileDialog.ShowDialog();

            if(DialogResult != DialogResult.Cancel)
            {

                string file = addFileDialog.FileName;
                try
                {
                    imgList.Add((Bitmap)Image.FromFile(file));
                }
                catch
                {
                    MessageBox.Show("Файлът е твърде голям или не е изображение");
                    return;
                }
                DialogResult res = MessageBox.Show("Image added! Would you like to go to it?", "File adding", MessageBoxButtons.YesNo);

                if(res == DialogResult.Yes)
                {
                    ChangeImage(imgList.Count-1);
                }
            }
        }
    }
}
