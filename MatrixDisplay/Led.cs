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

        public Led(int zeile, int spalte,
            int breite, int hoehe,
            Modul modul)
        {
            parentModul = modul;
            ledPixelBreite = breite;
            ledPixelHoehe = hoehe;
            
            this.zeile = zeile;
            this.spalte = spalte;


            // TODO

            int modulNr = parentModul.GetModulNr();
            
            int spaltenAnzahl = parentModul.GetSpalten();
            int zeilenAnzahl = parentModul.GetZeilen();

            int modulBreiteInPixel = spaltenAnzahl * ledPixelBreite;
            yPos = zeile * ledPixelHoehe;
            xPos = spalte * ledPixelBreite + 
                ( modulNr * modulBreiteInPixel);

            localIndex = zeile * spaltenAnzahl + spalte;

            globalIndex = localIndex 
                + modulNr * (zeilenAnzahl * spaltenAnzahl);
            
            

        }

        public bool IstAn()
        {
            return istAn;
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
            }else
            {
                istAn = true;
            }
        }

        public void ZeichneLed(Graphics graphics)
        {
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
