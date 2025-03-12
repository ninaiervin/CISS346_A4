using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmpClientConsumer
{
    public partial class FormSmpClientConsumer : Form
    {
        internal String MESSAGE_SEPERATOR = "<MESSAGE_SEPERATOR>";
        public FormSmpClientConsumer()
        {
            InitializeComponent();

            radioButtonLow.Checked = true;

            buttonGetMessage.Click += buttonGetMessage_Click;
        }

        private void buttonGetMessage_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxMessageContent.Clear();

                string serverIp = textBoxServerIPAddress.Text;
                int port;

                if (!int.TryParse(textBoxApplicationPortNumber.Text, out port))
                {
                    MessageBox.Show("Invalid port number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string priority = "0";
                if (radioButtonMedium.Checked) priority = "1";
                if (radioButtonHigh.Checked) priority = "2";

                string getMessage = "Version_1_0" + MESSAGE_SEPERATOR + "GetMessage" + MESSAGE_SEPERATOR + priority + MESSAGE_SEPERATOR;

                string message = Client.GetMessage(serverIp, port, getMessage);
                string messageFormatted = "";

                if (message == "Server not responding")
                {
                    messageFormatted = message;
                }
                else if (message != "\r\n")
                {
                    messageFormatted = DisplayMessage(message);
                }
                else
                {
                    messageFormatted = "No record";
                }

                textBoxMessageContent.Text = messageFormatted;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal String DisplayMessage(string message)
        {
            StringBuilder sb = new StringBuilder();

            string[] messageParts = Regex.Split(message, MESSAGE_SEPERATOR);
            Console.Write(messageParts[1]);

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

            return sb.ToString();
        }
    }
}