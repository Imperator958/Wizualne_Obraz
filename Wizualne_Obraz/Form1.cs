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

        private void All_green_pixels_Click(object sender, EventArgs e)
        {
            int i, j;
            for (i = 0; i < image.Width; i++)
            {
                for (j = 0; j < image.Height; j++)
                {
                    Color pixel = image.GetPixel(i, j);
                    image.SetPixel(i, j, DisplayGreen(pixel,50));
                }
            }
            pictureBox1.Image = image;
        }

        private void Negative_Click(object sender, EventArgs e)
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

        private Color DisplayGreen(Color c, int range)
        {
            float C = c.GetHue();
            float e = 1.5f * range;
            float G = Color.Green.GetHue();
            float delta = C - G;
            bool Ok = (Math.Abs(delta) < e);

            return Ok ? c : Color.White;
        }

        private void move_by_90_degree_Click(object sender, EventArgs e)
        {
            if(image != null)
            {
                int Width;
                image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                Width = pictureBox1.Width;
                pictureBox1.Width = pictureBox1.Height;
                pictureBox1.Height = Width;
                pictureBox1.Image = image;
                
            }
        }

        private void mirror_reflection_I_Click(object sender, EventArgs e)
        {
            if(image != null)
            {
                image.RotateFlip(RotateFlipType.RotateNoneFlipY);
                pictureBox1.Image = image;
            }
        }

        private void mirror_reflection_Click(object sender, EventArgs e)
        {
            if(image != null)
            {
                image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                pictureBox1.Image = image;
            }
        }
    }
}