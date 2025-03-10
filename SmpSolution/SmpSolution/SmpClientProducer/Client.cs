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
            TcpClient client = new TcpClient(serverIpAddress, port);
            NetworkStream networkStream = client.GetStream();

            //Send the SMP packet
            StreamWriter writer = new StreamWriter(networkStream);
            writer.WriteLine(message);
            writer.Flush();

            //Receive SMP Response from server
            StreamReader reader = new StreamReader(networkStream);
            string serverResponse = reader.ReadLine();

            //Done with the server
            reader.Close();
            writer.Close();

            ProcessResponsePacket(serverResponse, form);
        }
        private static void ProcessResponsePacket(string serverResponse, FormSmpClientProducer form)
        {
            form.RecordServerResponse(serverResponse);
        }
    }
}
