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

namespace SmpServer
{
    public partial class FormSmpServer: Form
    {
        String MESSAGE_SEPERATOR = "<MESSAGE_SEPERATOR>";
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

        public void RecordClientMessage(string clientMessage)
        {
            try
            {
                this.clientMessage = clientMessage;
                //this.messageType = typeMessage;
                //this.messagePriorty = messagePriorty;


                Invoke(new MethodInvoker(RecordClientMessage));
            }
            catch (Exception)
            {

            }
        }

        private void RecordClientMessage()
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
            }
            else
            {
                ReadSMPFGETMessageFromFile(packageContent);
            }
            //textBox2.AppendText(clientMessage + Environment.NewLine);

        }

        private void WriteSMPPUTMessageToFile(String[] packageContent, String clientMessage)
        {
            if (packageContent[1] == "0")
            {
                File.AppendAllText("Low.txt", clientMessage);
            }
            else if (packageContent[2] == "1")
            {
                File.AppendAllText("Medium.txt", clientMessage);
            }
            else
            {
                File.AppendAllText("High.txt", clientMessage);
            }
        }

        private void ReadSMPFGETMessageFromFile(String[] packageContent)
        {

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

        }
    }
}
