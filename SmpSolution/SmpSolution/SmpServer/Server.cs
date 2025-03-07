using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using SmpServer;


namespace SmpServer
{
    public class Server
    {
        static FormSmpServer serverForm;
        static TcpListener server;
        public static void Start(object obj)
        {
            Console.WriteLine("Started.");
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

            Console.WriteLine(message);

            serverForm.RecordClientMessage(message);

            string response = "Received message: " + DateTime.Now;

            string[] packageContent = Regex.Split(message, serverForm.MESSAGE_SEPERATOR);

            if (packageContent[0] == "SMPPUT")
            {
                serverForm.WriteSMPPUTMessageToFile(packageContent, message);
            }
            else if (packageContent[0] == "SMPGET")
            {
                serverForm.ReadSMPFGETMessageFromFile(packageContent);
                return;
            }

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
