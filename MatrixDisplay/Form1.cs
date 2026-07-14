using System.Diagnostics;
using System.IO.Ports;

namespace MatrixDisplay
{
    public partial class Form1 : Form
    {
        MatrixDisplay matrixDisplay;

        bool darfScrollen = false;

        public Form1()
        {
            InitializeComponent();
            // initialisiere das MatrixDisplay-Datenmodell mit 7 Modulen
            initMatrixDisplayDatenModel(7);

            // COM-Port-Liste füllen
            listBoxComPort.Items.AddRange(SerialPort.GetPortNames());
            if (listBoxComPort.Items.Count > 0) { listBoxComPort.SelectedIndex = 0; }

            // Timer initialisieren
            timer.Interval = 100;
            timer.Start();
        }

        public void initMatrixDisplayDatenModel(int anzahlModule)
        {
            matrixDisplayPanel.Width = anzahlModule * matrixDisplayPanel.Height;
            matrixDisplay = new MatrixDisplay(anzahlModule, 8, 8, matrixDisplayPanel.Width, matrixDisplayPanel.Height);
        }

        // initiales Zeichnen -und- immer bei Invalidate() 
        private void matrixDisplayPanel_Paint(object sender, PaintEventArgs e)
        {
            matrixDisplay.ZeichneMatrixDisplay(e.Graphics);
        }

        // Funktion welche die SW-Led  daten an die HW-Seite sendet.
        private void btnSendeDaten_Click(object sender, EventArgs e)
        {
            string portName = listBoxComPort.Text;
            Protokoll.SendeLedDatenAnStm32(matrixDisplay, portName);
        }

        private void matrixDisplay_MouseDown(object sender, MouseEventArgs e)
        {
            Led led = matrixDisplay.GetLedByPixel(e.X, e.Y);

            int r = (int)numRot.Value;
            int g = (int)numGruen.Value;
            int b = (int)numBlau.Value;

            // neu farbe übernehemn
            led.SetzeFarbe(r, g, b);

            led.Umschalten();
            matrixDisplayPanel.Invalidate();
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
                matrixDisplay.Scrollen();
            }
            matrixDisplayPanel.Invalidate();
        }

        private void btnAufModulBringen_Click(object sender, EventArgs e)
        {
            byte rot = (byte)numRot.Value;
            byte gruen = (byte)numGruen.Value;
            byte blau = (byte)numBlau.Value;
            string eingabe = textBox.Text;
            TextAufsModulBringerUeberarbeitet.BringeTextAufsModul(matrixDisplay, eingabe, rot, gruen, blau);
            matrixDisplayPanel.Invalidate();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            initMatrixDisplayDatenModel((int)numAnzahlModule.Value);
        }
    }
}