using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmpClientConsumer
{
    public partial class FormSmpClientConsumer : Form
    {
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

                textBoxMessageContent.Text = message;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}