namespace MatrixDisplay
{
    public partial class Form1 : Form
    {
        Modul modul;

        public Form1()
        {
            InitializeComponent();

            int breite = matrixDisplay.Width;
            int hoehe = matrixDisplay.Height;

            modul = new Modul(0, 8, 8, breite, hoehe);
        }

        private void matrixDisplay_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            modul.ZeichneAlleLeds(g);
        }

        private void matrixDisplay_MouseDown(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            Led led = modul.getLedByPixel(x, y);
            led.Umschalten();
            matrixDisplay.Invalidate();
        }
    }
}
