using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SmpClientProducer
{
    public partial class FormSmpClientProducer: Form
    {
        String MESSAGE_SEPERATOR =  "<MESSAGE_SEPERATOR>";
        String IPAddress = "127.0.0.1";
        int Port = 50400;
        String serverResponse;
        public FormSmpClientProducer()
        {
            InitializeComponent();
        }

        private void textBoxServerIPAddress_TextChanged(object sender, EventArgs e)
        {
            IPAddress = textBoxServerIPAddress.Text;
        }

        private void textBoxApplicationPortNumber_TextChanged(object sender, EventArgs e)
        {
            Port = Int32.Parse(textBoxApplicationPortNumber.Text);
        }

        private void textBoxMessageContent_TextChanged(object sender, EventArgs e)
        {
            textBoxServerResponse.Text = serverResponse;
        }

        private void buttonSendMessage_Click(object sender, EventArgs e)
        {
            textBoxServerResponse.Clear();
            Client.SendMessage(IPAddress, Port, createPackage(textBoxMessageContent.Text), this);
        }

        String createPackage(String message)
        {
            DateTime localDate = DateTime.Now;
            var culture = new CultureInfo("en-US");
            String date = localDate.ToString(culture);

            String priority;

            if (radioButtonLow.Checked)
            {
                priority = "0";
            } 
            else if (radioButtonMedium.Checked)
            {
                priority = "1";
            }
            else if (radioButtonHigh.Checked)
            {
                priority = "2";
            }
            else
            {
                priority = "1";
            }

            String textBoxMsg = textBoxMessageContent.Text;
            String encryptedMessage = Encryption.EncryptMessage(textBoxMsg, "Public.key");
            String signedmessage = SignMessage(encryptedMessage);



            return "Version_1_0" + MESSAGE_SEPERATOR + "PutMessage" + MESSAGE_SEPERATOR + priority + MESSAGE_SEPERATOR + date + MESSAGE_SEPERATOR + encryptedMessage + MESSAGE_SEPERATOR + signedmessage;
        }

        String SignMessage(String message)
        {
            try
            {
                //Convert message to byte array
                byte[] messageBytes = Encoding.ASCII.GetBytes(message);

                //Hash the message and sign the hash
                string privateKey = "private.key";
                byte[] signedHash = HashAndSignBytes(messageBytes, privateKey, SHA256.Create());

                //Get a string representation of the signed message
                string signedMessage = Convert.ToBase64String(signedHash);

                return signedMessage;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The data was not signed or verified");
            }
            return null;
        }

        public static byte[] HashAndSignBytes(byte[] messageBytes, string privateKey, HashAlgorithm hashAlg)
        {
            try
            {
                RSAParameters rsaParams = GetRsaParameters(privateKey);

                RSACryptoServiceProvider cryptoService = new RSACryptoServiceProvider();

                cryptoService.ImportParameters(rsaParams);

                //Using the SHA256 hashing algorithm, hash and sign the data.
                byte[] signedHash = cryptoService.SignData(messageBytes, hashAlg);

                return signedHash;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);

                return null;
            }
        }

        private static RSAParameters GetRsaParameters(string keyFile)
        {
            //Read the key from the file
            StreamReader reader = new StreamReader(keyFile);
            string keyString = reader.ReadToEnd();
            reader.Close();

            //Convert the key string to a RSAParameters object
            StringReader stringReader = new StringReader(keyString);
            XmlSerializer serializer = new XmlSerializer(typeof(RSAParameters));
            RSAParameters key = (RSAParameters)serializer.Deserialize(stringReader);
            return key;
        }

    


        public void RecordServerResponse(string serverResponse)
        {
            try
            {
                this.serverResponse = serverResponse;

                Invoke(new MethodInvoker(RecordServerResponse));
            }
            catch (Exception)
            {

            }
        }

        private void RecordServerResponse()
        {
            textBoxServerResponse.Text = serverResponse;
        }

        private void textBoxServerResponse_TextChanged(object sender, EventArgs e)
        {
            textBoxServerResponse.Text = serverResponse;
        }
    }
}
