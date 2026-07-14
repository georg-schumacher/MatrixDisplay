namespace MatrixDisplay
{
    // Das gesamte Display: eine Kette von n HW-Led-Modulen (je 8x8 Leds)
    public class MatrixDisplay
    {
        /*------ Attribute ------*/
        private Modul[] module;
        private int breite;
        private int hoehe;
        private int breiteProModul;

        private int zeilenProModul;
        private int spaltenProModul;

        /*------ Konstruktor ------*/
        public MatrixDisplay(int anzahlModule, int zeilenProModul, int spaltenProModul, int breite, int hoehe)
        {
            this.breite = breite;
            this.hoehe = hoehe;
            this.breiteProModul = breite / anzahlModule;
            this.zeilenProModul = zeilenProModul;
            this.spaltenProModul = spaltenProModul;

            module = new Modul[anzahlModule];
            for (int i = 0; i < anzahlModule; i++)
            {
                module[i] = new Modul(i, zeilenProModul, spaltenProModul, breiteProModul, hoehe);
            }
        }

        /*------ Methoden ------*/
        public Modul[] GetModule()
        {
            return module;
        }

        public int GetAnzahlLeds()
        {
            return module.Length * zeilenProModul * spaltenProModul;
        }

        public void ZeichneMatrixDisplay(Graphics g)
        {
            for (int i = 0; i < module.Length; i++)
            {
                module[i].ZeichneModul(g);
            }
        }

        // Led über die Gesamt-Koordinaten des Displays holen
        // (spalte läuft über alle Module: 0 .. anzahlModule*spaltenProModul-1)
        public Led GetLed(int zeile, int spalte)
        {
            int modulNr = spalte / spaltenProModul;
            int lokaleSpalte = spalte % spaltenProModul;

            return module[modulNr].getLedByZeileXSpalte(zeile, lokaleSpalte);
        }

        // Led über Pixel-Koordinaten des Panels holen
        public Led GetLedByPixel(int x, int y)
        {
            int modulNr = x / breiteProModul;

            Led led = module[modulNr].getLedByPixel(x - breiteProModul * modulNr, y);

            return led;
        }

        public void UmschaltenByPixel(int x, int y)
        {
            GetLedByPixel(x, y).Umschalten();
        }

        public void Scrollen()
        {
            Led[] ersteSpalte = module[0].GetErsteSpalte();
            for (int i = 0; i < module.Length - 1; i++)
            {
                module[i].SchiebeLinks();
                module[i].SetzeLetzteSpalteMit(module[i + 1].GetErsteSpalte());
            }
            module[module.Length - 1].SchiebeLinks();
            module[module.Length - 1].SetzeLetzteSpalteMit(ersteSpalte);
        }
    }
}
