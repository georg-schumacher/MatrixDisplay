namespace MatrixDisplay
{
    public class Led
    {
        private bool istAn;
        private int globalIndex;
        private int localIndex;
        private int zeile;
        private int spalte;
        private int xPos;
        private int yPos;
        private int ledPixelBreite;
        private int ledPixelHoehe;
        private Modul parentModul;
        //neu
        private Color farbe;

        public Led(int zeile, int spalte,
            int breite, int hoehe,
            Modul modul)
        {
            parentModul = modul;
            ledPixelBreite = breite;
            ledPixelHoehe = hoehe;

            this.zeile = zeile;
            this.spalte = spalte;

            int modulNr = parentModul.GetModulNr();

            int spaltenAnzahl = parentModul.GetSpalten();
            int zeilenAnzahl = parentModul.GetZeilen();

            int modulBreiteInPixel = spaltenAnzahl * ledPixelBreite;
            yPos = zeile * ledPixelHoehe;
            xPos = spalte * ledPixelBreite;

            localIndex = zeile * spaltenAnzahl + spalte;

            globalIndex = zeile * (spaltenAnzahl/8) + spalte;

        }

        public int getGlobalIndex()
        {
            return globalIndex;
        }

        public bool IstAn()
        {
            return istAn;
        }

        // neu
        public void SetzeFarbe(int r, int g, int b)
        {
            farbe = Color.FromArgb(r, g, b);
        }

        

        public void UebernehmeWerteVon(Led other)
        {
            this.istAn = other.istAn;
            // neu
            this.farbe = other.farbe;
        }

        public void Einschalten()
        {
            istAn = true;
        }

        public void Ausschalten()
        {
            istAn = false;
        }

        public void Umschalten()
        {
            if (istAn)
            {
                istAn = false;
            }
            else
            {
                istAn = true;
            }
        }

        public void ZeichneLed(Graphics graphics)
        {
            using SolidBrush brush = new SolidBrush(farbe);

            if (istAn)
            {
                graphics.FillRectangle(brush, xPos, yPos, ledPixelBreite, ledPixelHoehe);
            }
        }
    }
}