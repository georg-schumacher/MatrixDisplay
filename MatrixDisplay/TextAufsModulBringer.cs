namespace MatrixDisplay
{
    public class TextAufsModulBringerOriginal
    {
        private static Buchstaben buch = new Buchstaben();
        public static void BringeTextAufsModulOriginal(MatrixDisplay matrixDisplay, string eingabe, byte ROT, byte GRUEN, byte BLAU)
        {

            for (int i = 0; i < eingabe.Length; i++)
            {
                if (eingabe[i] == 'a' || eingabe[i] == 'A')
                {
                    for (int z = 0; z < buch.buchstabe_a.GetLength(0); z++)
                    {
                        for (int s = 0; s < buch.buchstabe_a.GetLength(1); s++)
                        {
                            if (buch.buchstabe_a[z, s] == true)
                            {
                                Led led = matrixDisplay.GetLed(z, s);
                                led.SetzeFarbe(ROT, GRUEN, BLAU);   
                                led.Einschalten();
                            }
                        }
                    }
                }
                else if (eingabe[i] == 'b' || eingabe[i] == 'B')
                {
                    for (int z = 0; z < buch.buchstabe_b.GetLength(0); z++)
                    {
                        for (int s = 0; s < buch.buchstabe_b.GetLength(1); s++)
                        {

                            if (buch.buchstabe_b[z, s ] == true)
                            {
                                Led led = matrixDisplay.GetLed(z, s);
                                led.SetzeFarbe(ROT, GRUEN, BLAU);
                                led.Einschalten();
                            }
                        }
                    }
                }
            }
        }
    }
}
