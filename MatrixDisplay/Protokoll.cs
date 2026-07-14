using System.IO.Ports;

namespace MatrixDisplay
{
    public class Protokoll
    {
        public static void SendeLedDatenAnStm32(MatrixDisplay display)
        {

            int bytesPerLed = 4;
            byte[] send_data = new byte[display.GetAnzahlLeds() * bytesPerLed];

            foreach (Modul modul in display.GetModule())
            {
                for (int row = 0; row < modul.GetZeilen(); row++)
                {
                    for (int col = 0; col < modul.GetSpalten(); col++)
                    {
                        Led led = modul.getLedByZeileXSpalte(row, col);
                        if (led.IstAn())
                        {
                            int shift_idx = led.getGlobalIndex() * bytesPerLed;
                            send_data[shift_idx] = 1;
                            send_data[shift_idx + 1] = led.GetFarbe().R; // Rot
                            send_data[shift_idx + 2] = led.GetFarbe().G; // Grün
                            send_data[shift_idx + 3] = led.GetFarbe().B; // Blau
                        }
                        else
                        {
                            int shift_idx = led.getGlobalIndex() * bytesPerLed;
                            send_data[shift_idx] = 0; // LED ist aus
                            send_data[shift_idx + 1] = 0;
                            send_data[shift_idx + 2] = 0;
                            send_data[shift_idx + 3] = 0;
                        }
                    }
                }
            }


            SerialPort _serialPort = new SerialPort("COM4", 9600, Parity.None, 8, StopBits.One);


            try
            {
                if (!(_serialPort.IsOpen))
                {
                    _serialPort.Open();
                }

                _serialPort.Write(send_data, 0, send_data.Length);
                _serialPort.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening/writing to serial port :: " + ex.Message, "Error!");
            }
        }
    }
}
