using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Xml.Serialization;
using CryptographyUtilities;

namespace SmpServer
{
    public partial class FormSmpServer: Form
    {
        internal String MESSAGE_SEPERATOR = "<MESSAGE_SEPERATOR>";
        public string IPAddress = "127.0.0.1";
        public int Port = 50400;
        private string messageType = "";
        private string messagePriorty = "";
        private string clientMessage;
        public FormSmpServer()
        {
            InitializeComponent();
        }

        private void startServerButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                ThreadPool.QueueUserWorkItem(Server.Start, this);

                //StatusMessageTextbox.Text = "Server started...";
            }
            catch (Exception)
            {
                MessageBox.Show("Server start error...", "Server Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBoxServerIPAddress_TextChanged(object sender, EventArgs e)
        {
            IPAddress = textBoxServerIPAddress.Text;
        }

        private void textBoxPortNumber_TextChanged(object sender, EventArgs e)
        {
            Port = Int32.Parse(textBoxPortNumber.Text);
        }

        public string RecordClientMessage(string clientMessage)
        {
            try
            {
                this.clientMessage = clientMessage;
                //this.messageType = typeMessage;
                //this.messagePriorty = messagePriorty;


                return (string) Invoke(new Func<string>(RecordClientMessage));
            }
            catch (Exception)
            {
                return null;
            }
        }

        private string RecordClientMessage()
        {
            // textbox1 message priorty
            //StatusMessageTextbox.Text = "Message received: " + DateTime.Now;
            String[] packageContent = Regex.Split(clientMessage, MESSAGE_SEPERATOR);
            textBoxMessageType.Text = packageContent[0];
            //textBox1.Text = packageContent[1]; // change later to low medium and high

            if (packageContent[1] == "0")
            {
                textBox1.Text = "Low";
            }
            else if (packageContent[1] == "1")
            {
                textBox1.Text = "Medium";
            } 
            else if (packageContent[1] == "2")
            {
                textBox1.Text = "High";
            }


            if (packageContent[0] == "SMPPUT")
            {
                WriteSMPPUTMessageToFile(packageContent, clientMessage);
                return null;
            }
            else
            {
                return ReadSMPFGETMessageFromFile(packageContent);
            }

        }

        internal void WriteSMPPUTMessageToFile(String[] packageContent, String clientMessage)
        {
            if (packageContent[1] == "0")
            {
                File.AppendAllText("Low.txt", clientMessage);
            }
            else if (packageContent[1] == "1")
            {
                File.AppendAllText("Medium.txt", clientMessage);
            }
            else
            {
                File.AppendAllText("High.txt", clientMessage);
            }
        }

        internal string ReadSMPFGETMessageFromFile(String[] packageContent)
        {
            string messageResponse = string.Empty;

            string priorityFile;
            switch (packageContent[1])
            {
                case "0":
                    priorityFile = "Low.txt";
                    break;
                case "1":
                    priorityFile = "Medium.txt";
                    break;
                case "2":
                    priorityFile = "High.txt";
                    break;
                default:
                    priorityFile = "Low.txt";
                    break;
            }

            try
            {
                if (File.Exists(priorityFile))
                {
                    string fileContent = File.ReadAllText(priorityFile);

                    if (!string.IsNullOrEmpty(fileContent))
                    {
                        string[] messages = fileContent.Split(new[] { "SMPPUT" }, StringSplitOptions.RemoveEmptyEntries);

                        if (messages.Length > 0)
                        {
                            string firstMessage = "SMPPUT" + messages[0];

                            

                            string[] messageParts = Regex.Split(firstMessage, MESSAGE_SEPERATOR);

                            
                            int endOfFirstMessage = fileContent.IndexOf("SMPPUT", fileContent.IndexOf("SMPPUT") + 1);
                            if (endOfFirstMessage == -1)
                            {
                                File.WriteAllText(priorityFile, "");
                            }
                            else
                            {
                                string newFileContent = fileContent.Substring(endOfFirstMessage);
                                File.WriteAllText(priorityFile, newFileContent);
                            }
                            messageResponse = firstMessage;
                        }
                        else
                        {
                            messageResponse = "No messages available in the queue.";
                        }
                    }
                    else
                    {
                        messageResponse = "Queue is empty.";
                    }
                }
                else
                {
                    messageResponse = "Priority queue not found.";
                }
            }
            catch (Exception ex)
            {
                messageResponse = "Error processing message: " + ex.Message;
            }

            return messageResponse;
        }



        private void groupBoxLastRece_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonLow_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButtonMedium_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxPriority_Enter(object sender, EventArgs e)
        {

        }

        private void radioButtonHigh_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonShowMessages_Click(object sender, EventArgs e)
        {
            textBox2.Clear();

            List<string> priorityFiles = new List<string>();

            if (radioButtonLow.Checked)
                priorityFiles.Add("Low.txt");
            else if (radioButtonMedium.Checked)
                priorityFiles.Add("Medium.txt");
            else if (radioButtonHigh.Checked)
                priorityFiles.Add("High.txt");
            else
                priorityFiles.AddRange(new[] { "Low.txt", "Medium.txt", "High.txt" });

            DisplayMessages(priorityFiles);
        }

        internal String DisplayMessage(string message, int messageCount)
        {
            StringBuilder sb = new StringBuilder();

            string fullMessage = "SMPPUT" + message;
            string[] messageParts = Regex.Split(fullMessage, MESSAGE_SEPERATOR);

            if (messageCount > 0)
            {
                sb.AppendLine($"Message #{messageCount}");
            }
            
            sb.AppendLine($"Type: {messageParts[0]}");

            string priority;
            switch (messageParts[1])
            {
                case "0":
                    priority = "Low";
                    break;
                case "1":
                    priority = "Medium";
                    break;
                case "2":
                    priority = "High";
                    break;
                default:
                    priority = "Unknown";
                    break;
            }

            sb.AppendLine($"Priority: {priority}");
            sb.AppendLine($"Timestamp: {messageParts[2]}");

            string encryptedContent = messageParts[3];
            try
            {
                string decryptedContent = Encryption.DecryptMessage(encryptedContent, "Private.key");
                sb.AppendLine($"Content: {decryptedContent}");
            }
            catch (Exception ex)
            {
                sb.AppendLine($"Content: [Decryption failed: {ex.Message}]");
            }

            sb.AppendLine("----------------------------");
            return sb.ToString();
        }
        private void DisplayMessages(IEnumerable<string> files)
        {
            StringBuilder allMessages = new StringBuilder();

            foreach (string file in files)
            {
                if (File.Exists(file))
                {
                    allMessages.AppendLine($"--- {file} ---");

                    string fileContent = File.ReadAllText(file);
                    if (!string.IsNullOrEmpty(fileContent))
                    {
                        string[] messages = fileContent.Split(new[] { "SMPPUT" }, StringSplitOptions.RemoveEmptyEntries);

                        if (messages.Length > 0)
                        {
                            int messageCount = 0;

                            foreach (string message in messages)
                            {
              
                                if (!string.IsNullOrEmpty(message))
                                {
                                    messageCount++;

                                    allMessages.Append(DisplayMessage(message, messageCount));
                                }
                            }

                            if (messageCount == 0)
                                allMessages.AppendLine("No valid messages found.");
                        }
                        else
                        {
                            allMessages.AppendLine("No messages found.");
                        }
                    }
                    else
                    {
                        allMessages.AppendLine("File is empty.");
                    }

                    allMessages.AppendLine();
                }
            }

            textBox2.Text = allMessages.Length > 0 ? allMessages.ToString() : "No message files found.";
        }
    }
}
