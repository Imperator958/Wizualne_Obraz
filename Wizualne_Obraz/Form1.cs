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