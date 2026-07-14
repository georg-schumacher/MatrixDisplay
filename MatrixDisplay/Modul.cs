
namespace MatrixDisplay
{
    public class Modul
    {
        private int modulNr;
        private Led[,] ledArray;
        private int anzahlZeilen;
        private int anzahlSpalten;
        private int breite;
        private int hoehe;

        public Modul(
            int modulNr,
            int zeilen, int spalten,
            int breite, int hoehe)
        {
            this.breite = breite;
            this.hoehe = hoehe;
            this.modulNr = modulNr;
            this.anzahlZeilen = zeilen;
            this.anzahlSpalten = spalten;
            ledArray = new Led[zeilen, spalten];

            int ledBreite = breite / anzahlSpalten;
            int ledHoehe = hoehe / anzahlZeilen;

            for (int z = 0; z < anzahlZeilen; z++)
            {
                for (int s = 0; s < anzahlSpalten; s++)
                {
                    Led neueLed;
                    neueLed = new Led(z, s,
                        ledBreite, ledHoehe, this);
                    ledArray[z, s] = neueLed;

                }
            }

        }
        public Led GetLedByLocalIndex(int localIndex)
        {
            // TODO
            return null;
        }

        public Led[,] getLedArray()
        {
            return ledArray;
        }

        public Led getLedByPixel(int x, int y)
        {
            int index_spalte = x / (breite / anzahlSpalten);
            int index_zeile = y / (hoehe / anzahlZeilen);
            return ledArray[index_zeile, index_spalte];
        }

        public void UmschaltenByPixel(int x, int y)
        {
            Led led = getLedByPixel(x, y);
            led.Umschalten();
        }
        public int GetModulNr()
        {
            return modulNr;
        }

        public int GetSpalten()
        {
            return anzahlSpalten;
        }

        public int GetZeilen()
        {
            return anzahlZeilen;
        }

        public void ZeichneAlleLeds(Graphics g)
        {
            for (int z = 0; z < anzahlZeilen; z++)
            {
                for (int s = 0; s < anzahlSpalten; s++)
                {
                    ledArray[z, s].ZeichneLed(g);
                }
            }
        }

        internal void Scrollen()
        {
            // Modul.Scrollen

            // Phase 1
            // TODO: Erste Spalte wegsichern als Led-Array !!

            // Phase 2
            // jede Led: eins nach-links schieben (Erste Spalte geht verloren)
            for (int s = 0; s < anzahlSpalten - 1; s++)
            {
                for (int z = 0; z < anzahlZeilen; z++)
                {
                    Led led_links = ledArray[z, s];
                    Led led_rechts = ledArray[z, s + 1];
                    led_links.UebernehmeWerteVon(led_rechts);
                }
            }

            // Phase 3
            // TODO: 



        }
    }
}
