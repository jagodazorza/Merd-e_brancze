using System.Drawing.Imaging;

namespace Merdże_brancze
{
    public partial class Form1 : Form
    {
        public string filename;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Load();
        }

     

        public void Load()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            // openFileDialog1.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
            openFileDialog1.Title = "Wybierz plik CSV do wczytania";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Image != null)
            {
                if (radioButton1.Checked) pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                else if (radioButton2.Checked) pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                else if (radioButton3.Checked) pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);

                pictureBox1.Refresh();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
            
                Bitmap bmp = new Bitmap(pictureBox1.Image);

                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {

                        Color originalColor = bmp.GetPixel(x, y);

                        Color invertedColor = Color.FromArgb(originalColor.A,
                                                             255 - originalColor.R,
                                                             255 - originalColor.G,
                                                             255 - originalColor.B);
                        bmp.SetPixel(x, y, invertedColor);
                    }
                }
                pictureBox1.Image = bmp;
                pictureBox1.Refresh();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {

                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                Refresh();
            }
            }
        }
        }

        private void green_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {

                Bitmap bmp = new Bitmap(pictureBox1.Image);

                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {

                        Color originalColor = bmp.GetPixel(x, y);

                        if (originalColor.G < originalColor.B || originalColor.G < originalColor.R)
                        {
                            Color blackColor = Color.FromArgb(originalColor.A, 0, 0, 0);
                            bmp.SetPixel(x, y, blackColor);
                        }


                    }
                    pictureBox1.Image = bmp;
                    pictureBox1.Refresh();
                }
                }
            }
    }
}
