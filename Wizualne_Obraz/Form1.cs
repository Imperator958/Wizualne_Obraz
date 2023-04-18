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
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(ofd.FileName);
                pictureBox1.Image = new Bitmap(image);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(image != null)
            {
                int W;
                image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                W = pictureBox1.Width;
                pictureBox1.Width = pictureBox1.Height;
                pictureBox1.Height = W;
                pictureBox1.Image = image;
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(image != null)
            {
                image.RotateFlip(RotateFlipType.RotateNoneFlipY);
                pictureBox1.Image = image;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(image != null)
            {
                image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                pictureBox1.Image = image;
            }
        }
    }
}