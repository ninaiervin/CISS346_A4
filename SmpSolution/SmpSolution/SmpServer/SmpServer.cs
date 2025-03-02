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

namespace SmpServer
{
    public partial class FormSmpServer: Form
    {
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
            textBox2
                .AppendText(
                clientMessage + Environment.NewLine);



            //StatusMessageTextbox.Text = "Message received: " + DateTime.Now;
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
