using System.Drawing;

namespace HueClickGenerate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Point click;
        Graphics g;
        private void button1_Click(object sender, EventArgs e)
        {
            g = CreateGraphics();
            g.Clear(Color.White);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            g.Clear(Color.White);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            click = e.Location;
            Random rnd = new Random();
            int colorR = rnd.Next(0, 255);
            int colorG = rnd.Next(0, 255);
            int colorB = rnd.Next(0, 255);
            SolidBrush brushE = new SolidBrush(Color.FromArgb(colorR, colorG, colorB));
            int size1 = rnd.Next(10, 200);
            int size2 = rnd.Next(10, 200);
            g.FillEllipse(brushE, click.X - (size1 / 2), click.Y - (size2 / 2), size1, size2);
        }
    }
}
