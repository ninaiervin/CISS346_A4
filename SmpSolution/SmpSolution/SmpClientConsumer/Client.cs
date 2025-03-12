using System;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace SmpClientConsumer
{
    public class Client
    {
        private const string MESSAGE_SEPARATOR = "<MESSAGE_SEPERATOR>";

        public static string GetMessage(string serverIpAddress, int port, string message)
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

                return response;
            }
            catch (Exception ex)
            {
                //throw new Exception($"Communication error: {ex.Message}", ex);
                return "Server not responding";
            }
        }
    }
}