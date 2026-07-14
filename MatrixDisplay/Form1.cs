using System.Diagnostics;
using System.IO.Ports;

namespace MatrixDisplay
{
    public partial class Form1 : Form
    {
        Modul modul;

        bool darfScrollen = false;

        public Form1()
        {
            InitializeComponent();

            btnColorDialog.Enabled = true;

            int breite = matrixDisplay.Width;
            int hoehe = matrixDisplay.Height;
            // ........................ 10 = Anzahl der 8x8 HW-Led-Module
            modul = new Modul(0, 8, 8 * 10, breite, hoehe);

            // Optional: Scroll-Button zum Ein/Aus
            btnScroll.Click += btnScroll_Click;

            timer.Interval = 100;
            timer.Start();
        }

        // initiales Zeichnen -und- immer bei Invalidate() 
        private void matrixDisplay_Paint(object sender, PaintEventArgs e)
        {
            modul.ZeichneAlleLeds(e.Graphics);
        }

        // Funktion welche die SW-Led  daten an die HW-Seite sendet.
        private void btnSendeDaten_Click(object sender, EventArgs e)
        {
            Protokoll.SendeLedDatenAnStm32(modul);
        }

        private void matrixDisplay_MouseDown(object sender, MouseEventArgs e)
        {
            Led led = modul.getLedByPixel(e.X, e.Y);

            int r = (int)numRot.Value;
            int g = (int)numGruen.Value;
            int b = (int)numBlau.Value;

            // neu farbe übernehemn
            led.SetzeFarbe(r, g, b);

            led.Umschalten();
            matrixDisplay.Invalidate();
        }

        //neu (haben google verwendet)
        private void btnColorDialog_Click(object sender, EventArgs e)
        {
            colorDialog.AllowFullOpen = true;
            colorDialog.FullOpen = true;
            colorDialog.AnyColor = true;
            colorDialog.SolidColorOnly = true;

            colorDialog.Color = Color.FromArgb(
                (int)numRot.Value,
                (int)numGruen.Value,
                (int)numBlau.Value);

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                numRot.Value = colorDialog.Color.R;
                numGruen.Value = colorDialog.Color.G;
                numBlau.Value = colorDialog.Color.B;
            }
        }

        private void btnScroll_Click(object? sender, EventArgs e)
        {
            darfScrollen = !darfScrollen;
        }

        // Timer Verhalten
        private void timer_Tick(object sender, EventArgs e)
        {
            if (darfScrollen)
            {
                modul.Scrollen();
            }
            matrixDisplay.Invalidate();
        }

        private void btnScroll_Click(object sender, EventArgs e)
        {
            darfScrollen = !darfScrollen;
        }
    }
}