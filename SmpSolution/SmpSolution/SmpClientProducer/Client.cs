using System;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;

namespace SmpClientProducer
{
    public class Client
    {
        public static void SendMessage(string serverIpAddress, int port, string message, FormSmpClientProducer form)
        {
            string response = string.Empty;
            try
            {
                using (TcpClient client = new TcpClient(serverIpAddress, port))
                {
                    using (NetworkStream networkStream = client.GetStream())
                    {
                        using (StreamWriter writer = new StreamWriter(networkStream))
                        {
                            writer.WriteLine(message);
                            writer.Flush();
                            using (StreamReader reader = new StreamReader(networkStream))
                            {
                                response = reader.ReadToEnd();
                            }
                        }
                    }
                }

                ProcessResponsePacket(response, form);
            }
            catch (Exception ex)
            {
                //throw new Exception($"Communication error: {ex.Message}", ex);
                ProcessResponsePacket("Server not responding", form);
            }
        }
        private static void ProcessResponsePacket(string serverResponse, FormSmpClientProducer form)
        {
            form.RecordServerResponse(serverResponse);
        }
    }
}
