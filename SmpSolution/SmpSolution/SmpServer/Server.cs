using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using SmpServer;

namespace SmpServer
{
    public class Server
    {
        static FormSmpServer serverForm;
        static TcpListener server;
        public static void Start(object obj)
        {
            serverForm = obj as FormSmpServer;

            server = new TcpListener(IPAddress.Parse(serverForm.IPAddress), serverForm.Port);

            try
            {
                server.Start();

                while (true)
                {
                    TcpClient clientConnection = server.AcceptTcpClient();

                    ProcessConnection(clientConnection);

                    clientConnection.Close();
                }
            }
            catch (Exception)
            {

            }
        }

        public static void ProcessConnection(TcpClient clientConnection)
        {
            NetworkStream networkStream = clientConnection.GetStream();

            StreamReader streamReader = new StreamReader(networkStream);

            string message = streamReader.ReadLine();

            serverForm.RecordClientMessage(message);

            string response = "Received message: " + DateTime.Now;

            SendResponse(response, networkStream);

            streamReader.Close();
        }

        private static void SendResponse(String response, NetworkStream networkStream)
        {
            StreamWriter streamWriter = new StreamWriter(networkStream);

            streamWriter.WriteLine(response);

            streamWriter.Close();
        }

        public static void Stop()
        {
            server.Stop();
        }
    }
}
