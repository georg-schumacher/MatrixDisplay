using System.Diagnostics;
using System.IO.Ports;

namespace MatrixDisplay
{
    public partial class Form1 : Form
    {
        Modul modul;

        bool darfScrollen = true;

        public Form1()
        {
            InitializeComponent();

            btnColorDialog.Enabled = false;

            int breite = matrixDisplay.Width;
            int hoehe = matrixDisplay.Height;
            // ........................ 10 = Anzahl der 8x8 HW-Led-Module
            modul = new Modul(0, 8, 8 * 10, breite, hoehe);

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
            // TODO: was ist mit der Farbe?
            Led led = modul.getLedByPixel(e.X, e.Y);
            led.Umschalten();
            matrixDisplay.Invalidate();
        }




        // Option / Bonus - Farbauswahl per Color-Dialog
        private void btnColorDialog_Click(object sender, EventArgs e)
        {

            colorDialog.ShowDialog();
            // OPTIONAL / TODO: Hier kann man die gewählte farbe verwenden

        }



        // Timer Verhalten
        private void timer_Tick(object sender, EventArgs e)
        {
            // TODO: SCROLLEN
            if (darfScrollen)
            {
                modul.Scrollen();
            }
            matrixDisplay.Invalidate();
        }
    }
}
