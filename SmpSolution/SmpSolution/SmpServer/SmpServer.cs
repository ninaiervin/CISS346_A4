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
using System.Windows.Forms.VisualStyles;

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

                return (string) Invoke(new Func<string>(RecordClientMessage));
            }
            catch (Exception)
            {
                return null;
            }
        }

        private string RecordClientMessage()
        {
            String[] packageContent = Regex.Split(clientMessage, MESSAGE_SEPERATOR);
            textBoxMessageType.Text = packageContent[0];

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
                WriteSMPPUTMessageToFile(packageContent);
                return "put";
            }
            else
            {
                return ReadSMPFGETMessageFromFile(packageContent);
            }
        }

        internal void WriteSMPPUTMessageToFile(String[] packageContent)
        {
            String filecontent = null;
            for (int i = 0; i < packageContent.Length; i++)
            {
                filecontent += packageContent[i] + Environment.NewLine;
            }
            if (packageContent[1] == "0")
            {
                File.AppendAllText("Low.txt", filecontent);
            }
            else if (packageContent[1] == "1")
            {
                File.AppendAllText("Medium.txt", filecontent);
            }
            else if (packageContent[1] == "2")
            {
                File.AppendAllText("High.txt", filecontent);
            }
        }

        internal string ReadSMPFGETMessageFromFile(String[] packageContent)
        {
            string messageResponse = string.Empty;
            StringBuilder record = new StringBuilder();


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
                        String currLine = "";
                        int i = 0;
                        using (StreamReader read = new StreamReader(priorityFile))
                        {
                            using (var write = new System.IO.StreamWriter("temp.txt"))
                            {
                                while ((currLine = read.ReadLine()) != null)
                                {
                                    if (i < 5)
                                    {
                                        record.Append(currLine + MESSAGE_SEPERATOR + Environment.NewLine);
                                    }
                                    else
                                    {
                                        write.WriteLine(currLine);
                                    }
                                    i++;
                                }
                            }
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

            try
            {
                // Replace the file.
                File.Replace("temp.txt", priorityFile, null, false);

            }
            catch (Exception e)
            {
                messageResponse = "Failed to update file";
            }

            return record.ToString();
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

            string[] messageParts = Regex.Split(message, MESSAGE_SEPERATOR);

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
                string replacement = Regex.Replace(encryptedContent, @"\t|\n|\r", string.Empty);
                string decryptedContent = Encryption.DecryptMessage(replacement, "Private.key");
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
            int messageCount = 0;

            foreach (string file in files)
            {
                if (File.Exists(file))
                {
                    allMessages.AppendLine($"--- {file} ---");

                    string fileContent = File.ReadAllText(file);
                    if (!string.IsNullOrEmpty(fileContent))
                    {
                        using (StreamReader read = new StreamReader(file))
                        {
                            string line;
                            string section = "";
                            int i = 0;
                            while ((line = read.ReadLine()) != null)
                            {
                                if (i < 4)
                                {
                                    section += line + MESSAGE_SEPERATOR;
                                }
                                else if (i == 4)
                                {
                                    section += line + MESSAGE_SEPERATOR;
                                    messageCount++;

                                    allMessages.Append(DisplayMessage(section, messageCount));
                                    section = string.Empty;
                                    i = -1;
                                }
                                i++;
                            }
                        }

                        if (messageCount == 0)
                            allMessages.AppendLine("No valid messages found.");

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
