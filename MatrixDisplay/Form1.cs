using System.Diagnostics;
using System.IO.Ports;

namespace MatrixDisplay
{
    public partial class Form1 : Form
    {
        Modul modul;
        public Buchstaben buch = new Buchstaben();

        bool darfScrollen = false;

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

        private void btnAufModulBringen_Click(object sender, EventArgs e)
        {
            
            string eingabe = textBox.Text;
            for(int i = 0; i < eingabe.Length; i++)
            {
                if (eingabe[i] == 'a' || eingabe[i] == 'A')
                {
                    for(int s = 0;s < buch.buchstabe_a.GetLength(0); s++)
                    {
                        for(int z = 0;z < buch.buchstabe_a.GetLength(1); z++)
                        {
                            if (buch.buchstabe_a[s,z] == true)
                            {
                                Led led = modul.getLed(z,s);
                                led.Umschalten();
                                matrixDisplay.Invalidate();
                            }
                        }
                    }
                }
                else if (eingabe[i] == 'b' || eingabe[i] == 'B')
                {
                    for (int s = 0; s < buch.buchstabe_b.GetLength(0); s++)
                    {
                        for (int z = 0; z < buch.buchstabe_b.GetLength(1); z++)
                        {

                            if (buch.buchstabe_b[s, z] == true)
                            {
                                Led led = modul.getLed(z, s);
                                led.Umschalten();
                                matrixDisplay.Invalidate();
                            }
                        }
                    }
                }
            }
            


        }
    }
}
