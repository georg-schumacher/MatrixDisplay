using System.IO.Ports;

namespace MatrixDisplay
{
    public class Protokoll
    {
        public static void SendeLedDatenAnStm32(Modul modul)
        {
            Led[,] led_array = modul.getLedArray();
            byte[] send_data = new byte[modul.GetSpalten() * modul.GetZeilen() * 4];
            int send_counter = 0;

            Random rnd = new Random(); // Todo: Remove this and take the real led color!

            for (int row = 0; row < modul.GetZeilen(); row++)
            {
                for (int col = 0; col < modul.GetSpalten(); col++)
                {
                    Led l = led_array[row, col];
                    if (l.IstAn())
                    {
                        int shift_idx = l.getGlobalIndex() * 4;
                        send_data[shift_idx] = 1;
                        send_data[shift_idx + 1] = (byte)rnd.Next(0, 255); // Rot
                        send_data[shift_idx + 2] = (byte)rnd.Next(0, 255); // Grün
                        send_data[shift_idx + 3] = (byte)rnd.Next(0, 255); // Blau


                    }
                    else
                    {
                        int shift_idx = l.getGlobalIndex() * 4;
                        send_data[shift_idx] = 0; // LED ist aus
                        send_data[shift_idx + 1] = 0;
                        send_data[shift_idx + 2] = 0;
                        send_data[shift_idx + 3] = 0;
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
