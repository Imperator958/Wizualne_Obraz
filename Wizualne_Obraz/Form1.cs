namespace Wizualne_Obraz
{
    public partial class Form1 : Form
    {
        Bitmap image;
        OpenFileDialog ofd = new OpenFileDialog();

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofd.Filter = "BMP (*.BMP)|*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(ofd.FileName);
                pictureBox1.Image = new Bitmap(image);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i, j;
            for(i = 0; i < image.Width; i++)
            {
                for(j = 0; j < image.Height; j++)
                {
                    Color pixel = image.GetPixel(i,j);
                    Color color = Color.FromArgb(0, pixel.G, 0);
                    image.SetPixel(i,j, color);
                }
            }

            pictureBox1.Image = image;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i, j;
            for (i = 0; i < image.Width; i++)
            {
                for (j = 0; j < image.Height; j++)
                {
                    Color pixel = image.GetPixel(i, j);
                    Color color = Color.FromArgb(255-pixel.R,255-pixel.G,255-pixel.B);
                    image.SetPixel(i, j, color);
                }
            }

            pictureBox1.Image = image;
        }
    }
}