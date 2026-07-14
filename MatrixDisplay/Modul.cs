
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
        private int ledBreite;
        private int ledHoehe;

        public Modul(int modulNr, int zeilen, int spalten, int breite, int hoehe)
        {
            this.breite = breite;
            this.hoehe = hoehe;
            this.modulNr = modulNr;
            this.anzahlZeilen = zeilen;
            this.anzahlSpalten = spalten;
            ledArray = new Led[zeilen, spalten];

            ledBreite = breite / anzahlSpalten;
            ledHoehe = hoehe / anzahlZeilen;

            for (int z = 0; z < anzahlZeilen; z++)
            {
                for (int s = 0; s < anzahlSpalten; s++)
                {
                    ledArray[z, s] = new Led(z, s, ledBreite, ledHoehe, this);
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
        public Led getLedByZeileXSpalte(int zeile, int spalte)
        {
            return ledArray[zeile, spalte];
        }

        public Led getLedByPixel(int x, int y)
        {

            int ledBreite = breite / anzahlSpalten;
            int ledHoehe = hoehe / anzahlZeilen;

            int index_spalte = x / ledBreite;
            int index_zeile = y / ledHoehe;

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

        public void ZeichneModul(Graphics g)
        {
            for (int z = 0; z < anzahlZeilen; z++)
            {
                for (int s = 0; s < anzahlSpalten; s++)
                {
                    ledArray[z, s].ZeichneLed(g);
                }
            }
        }

        // Kopie der ersten Spalte (Zustand + Farbe) als eigenständige Leds,
        // damit die Werte das Schieben überleben
        public Led[] GetErsteSpalte()
        {
            Led[] ersteSpalte = new Led[anzahlZeilen];

            for (int z = 0; z < anzahlZeilen; z++)
            {
                ersteSpalte[z] = new Led(z, 0, ledBreite, ledHoehe, this);
                ersteSpalte[z].UebernehmeWerteVon(ledArray[z, 0]);
            }
            return ersteSpalte;
        }

        public void SchiebeLinks()
        {
            for (int z = 0; z < anzahlZeilen; z++)
            {
                for (int s = 0; s < anzahlSpalten - 1; s++)
                {
                    ledArray[z, s].UebernehmeWerteVon(ledArray[z, s + 1]);
                }
            }
        }

        public void SetzeLetzteSpalteMit(Led[] bufferSpalte)
        {
            int index_GanzRechts  = anzahlSpalten - 1;
            for (int z = 0; z < anzahlZeilen; z++)
            {
                ledArray[z, index_GanzRechts].UebernehmeWerteVon(bufferSpalte[z]);
            }
        }


    }
}
