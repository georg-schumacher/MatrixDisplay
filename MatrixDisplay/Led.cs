namespace MatrixDisplay
{
    public class Led
    {
        // TODO Farbe 
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

        public void UebernehmeWerteVon(Led other)
        {
            this.istAn = other.istAn;
            // TODO Farbe übernehmen
        }

        // TODO 
        // public void SetzeFarbe()
        //
        


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
            }else
            {
                istAn = true;
            }
        }

        public void ZeichneLed(Graphics graphics)
        {
            // TODO Farbe
            int r = 0; 
            int g = 255; 
            int b = 0;
            Color color = Color.FromArgb(r, g, b);            
            SolidBrush meinGruen = new SolidBrush(color);

            if(istAn)
            {
                graphics.FillRectangle(meinGruen, xPos, yPos, ledPixelBreite, ledPixelHoehe);
            }
            meinGruen.Dispose();

        }




    }
}
