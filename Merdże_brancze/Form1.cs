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
    }
}
