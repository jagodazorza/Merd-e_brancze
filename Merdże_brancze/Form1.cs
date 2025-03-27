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
    }
}
