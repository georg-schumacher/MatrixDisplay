namespace MatrixDisplay
{
    public class TextAufsModulBringerUeberarbeitet
    {
        private static Buchstaben buch = new Buchstaben();
        private static MatrixDisplay matrixDisplay;
        private static byte ROT;
        private static byte GRUEN;
        private static byte BLAU;
        private static string eingabeText;

        public static void BringeTextAufsModul(MatrixDisplay matrixDisplay, string eingabeText, byte ROT, byte GRUEN, byte BLAU)
        {
            TextAufsModulBringerUeberarbeitet.matrixDisplay = matrixDisplay;
            TextAufsModulBringerUeberarbeitet.eingabeText = eingabeText;
            TextAufsModulBringerUeberarbeitet.ROT = ROT;
            TextAufsModulBringerUeberarbeitet.GRUEN = GRUEN;
            TextAufsModulBringerUeberarbeitet.BLAU = BLAU;


            // Wir gehen jeden Buchstaben in der Eingabe durch
            for (int zeichenNummer = 0; zeichenNummer < eingabeText.Length; zeichenNummer++)
            {
                // aus "Hugo"[2] wird 'g'
                char eingabeBuchstabe = eingabeText[zeichenNummer];

                // aus 'g' wird 'G'
                eingabeBuchstabe = char.ToUpper(eingabeBuchstabe);


                switch (eingabeBuchstabe)
                {
                    case 'A':
                        ZeichneBuchstabe(buch.buchstabe_a, zeichenNummer);
                        break;
                    case 'B':
                        ZeichneBuchstabe(buch.buchstabe_b, zeichenNummer);
                        break;
                }
            }
        }



        private static void ZeichneBuchstabe(bool[,] buchstabe, int zeichenNummer)
        {
            for (int z = 0; z < buchstabe.GetLength(0); z++)
            {
                for (int s = 0; s < buchstabe.GetLength(1); s++)
                {
                    if (buchstabe[z, s] == true)
                    {
                        // an dieser Stelle 
                        // muss die Position des Buchstabens auf dem Display berechnet werden
                        int globaleSpalte = s + (zeichenNummer * Buchstaben.BUCHSTABENBREITE);
                        Led led = matrixDisplay.GetLed(z, globaleSpalte);
                        led.SetzeFarbe(ROT, GRUEN, BLAU);
                        led.Einschalten();
                    }
                }
            }
        }
    }
}