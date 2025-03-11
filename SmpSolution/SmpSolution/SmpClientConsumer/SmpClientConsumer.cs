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

                string message = Client.GetMessage(serverIp, port, priority);

                string messageFormatted = DisplayMessage(message, 0);



                textBoxMessageContent.Text = messageFormatted;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}