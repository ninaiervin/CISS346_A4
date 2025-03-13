namespace SmpClientProducer
{
    partial class FormSmpClientProducer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.textBoxApplicationPortNumber = new System.Windows.Forms.TextBox();
            this.labelApplicationPortNumber = new System.Windows.Forms.Label();
            this.textBoxServerIPAddress = new System.Windows.Forms.TextBox();
            this.labelServerIPAddress = new System.Windows.Forms.Label();
            this.labelServerResponse = new System.Windows.Forms.Label();
            this.textBoxServerResponse = new System.Windows.Forms.TextBox();
            this.groupBoxMessages = new System.Windows.Forms.GroupBox();
            this.buttonSendMessage = new System.Windows.Forms.Button();
            this.textBoxMessageContent = new System.Windows.Forms.TextBox();
            this.labelMessageContent = new System.Windows.Forms.Label();
            this.groupBoxPriority = new System.Windows.Forms.GroupBox();
            this.radioButtonHigh = new System.Windows.Forms.RadioButton();
            this.radioButtonMedium = new System.Windows.Forms.RadioButton();
            this.radioButtonLow = new System.Windows.Forms.RadioButton();
            this.groupBoxSettings.SuspendLayout();
            this.groupBoxMessages.SuspendLayout();
            this.groupBoxPriority.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.textBoxApplicationPortNumber);
            this.groupBoxSettings.Controls.Add(this.labelApplicationPortNumber);
            this.groupBoxSettings.Controls.Add(this.textBoxServerIPAddress);
            this.groupBoxSettings.Controls.Add(this.labelServerIPAddress);
            this.groupBoxSettings.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(565, 77);
            this.groupBoxSettings.TabIndex = 0;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Settings";
            // 
            // textBoxApplicationPortNumber
            // 
            this.textBoxApplicationPortNumber.Location = new System.Drawing.Point(429, 30);
            this.textBoxApplicationPortNumber.Name = "textBoxApplicationPortNumber";
            this.textBoxApplicationPortNumber.Size = new System.Drawing.Size(100, 22);
            this.textBoxApplicationPortNumber.TabIndex = 3;
            this.textBoxApplicationPortNumber.Text = "50400";
            this.textBoxApplicationPortNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxApplicationPortNumber.TextChanged += new System.EventHandler(this.textBoxApplicationPortNumber_TextChanged);
            // 
            // labelApplicationPortNumber
            // 
            this.labelApplicationPortNumber.AutoSize = true;
            this.labelApplicationPortNumber.Location = new System.Drawing.Point(271, 33);
            this.labelApplicationPortNumber.Name = "labelApplicationPortNumber";
            this.labelApplicationPortNumber.Size = new System.Drawing.Size(152, 16);
            this.labelApplicationPortNumber.TabIndex = 2;
            this.labelApplicationPortNumber.Text = "Application Port Number";
            // 
            // textBoxServerIPAddress
            // 
            this.textBoxServerIPAddress.Location = new System.Drawing.Point(149, 30);
            this.textBoxServerIPAddress.Name = "textBoxServerIPAddress";
            this.textBoxServerIPAddress.Size = new System.Drawing.Size(100, 22);
            this.textBoxServerIPAddress.TabIndex = 1;
            this.textBoxServerIPAddress.Text = "127.0.0.1";
            this.textBoxServerIPAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxServerIPAddress.TextChanged += new System.EventHandler(this.textBoxServerIPAddress_TextChanged);
            // 
            // labelServerIPAddress
            // 
            this.labelServerIPAddress.AutoSize = true;
            this.labelServerIPAddress.Location = new System.Drawing.Point(27, 33);
            this.labelServerIPAddress.Name = "labelServerIPAddress";
            this.labelServerIPAddress.Size = new System.Drawing.Size(116, 16);
            this.labelServerIPAddress.TabIndex = 0;
            this.labelServerIPAddress.Text = "Server IP Address";
            // 
            // labelServerResponse
            // 
            this.labelServerResponse.AutoSize = true;
            this.labelServerResponse.Location = new System.Drawing.Point(39, 110);
            this.labelServerResponse.Name = "labelServerResponse";
            this.labelServerResponse.Size = new System.Drawing.Size(113, 16);
            this.labelServerResponse.TabIndex = 1;
            this.labelServerResponse.Text = "Server Response";
            // 
            // textBoxServerResponse
            // 
            this.textBoxServerResponse.Location = new System.Drawing.Point(158, 107);
            this.textBoxServerResponse.Name = "textBoxServerResponse";
            this.textBoxServerResponse.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxServerResponse.Size = new System.Drawing.Size(397, 22);
            this.textBoxServerResponse.TabIndex = 2;
            this.textBoxServerResponse.TextChanged += new System.EventHandler(this.textBoxServerResponse_TextChanged);
            // 
            // groupBoxMessages
            // 
            this.groupBoxMessages.Controls.Add(this.buttonSendMessage);
            this.groupBoxMessages.Controls.Add(this.textBoxMessageContent);
            this.groupBoxMessages.Controls.Add(this.labelMessageContent);
            this.groupBoxMessages.Controls.Add(this.groupBoxPriority);
            this.groupBoxMessages.Location = new System.Drawing.Point(12, 150);
            this.groupBoxMessages.Name = "groupBoxMessages";
            this.groupBoxMessages.Size = new System.Drawing.Size(565, 297);
            this.groupBoxMessages.TabIndex = 3;
            this.groupBoxMessages.TabStop = false;
            this.groupBoxMessages.Text = "Messages";
            // 
            // buttonSendMessage
            // 
            this.buttonSendMessage.Location = new System.Drawing.Point(232, 237);
            this.buttonSendMessage.Name = "buttonSendMessage";
            this.buttonSendMessage.Size = new System.Drawing.Size(280, 40);
            this.buttonSendMessage.TabIndex = 3;
            this.buttonSendMessage.Text = "Send Message";
            this.buttonSendMessage.UseVisualStyleBackColor = true;
            this.buttonSendMessage.Click += new System.EventHandler(this.buttonSendMessage_Click);
            // 
            // textBoxMessageContent
            // 
            this.textBoxMessageContent.Location = new System.Drawing.Point(200, 64);
            this.textBoxMessageContent.Multiline = true;
            this.textBoxMessageContent.Name = "textBoxMessageContent";
            this.textBoxMessageContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxMessageContent.Size = new System.Drawing.Size(343, 155);
            this.textBoxMessageContent.TabIndex = 2;
            this.textBoxMessageContent.TextChanged += new System.EventHandler(this.textBoxMessageContent_TextChanged);
            // 
            // labelMessageContent
            // 
            this.labelMessageContent.AutoSize = true;
            this.labelMessageContent.Location = new System.Drawing.Point(197, 32);
            this.labelMessageContent.Name = "labelMessageContent";
            this.labelMessageContent.Size = new System.Drawing.Size(112, 16);
            this.labelMessageContent.TabIndex = 1;
            this.labelMessageContent.Text = "Message Content";
            // 
            // groupBoxPriority
            // 
            this.groupBoxPriority.Controls.Add(this.radioButtonHigh);
            this.groupBoxPriority.Controls.Add(this.radioButtonMedium);
            this.groupBoxPriority.Controls.Add(this.radioButtonLow);
            this.groupBoxPriority.Location = new System.Drawing.Point(30, 32);
            this.groupBoxPriority.Name = "groupBoxPriority";
            this.groupBoxPriority.Size = new System.Drawing.Size(136, 156);
            this.groupBoxPriority.TabIndex = 0;
            this.groupBoxPriority.TabStop = false;
            this.groupBoxPriority.Text = "Priority";
            // 
            // radioButtonHigh
            // 
            this.radioButtonHigh.AutoSize = true;
            this.radioButtonHigh.Location = new System.Drawing.Point(31, 108);
            this.radioButtonHigh.Name = "radioButtonHigh";
            this.radioButtonHigh.Size = new System.Drawing.Size(56, 20);
            this.radioButtonHigh.TabIndex = 2;
            this.radioButtonHigh.Text = "High";
            this.radioButtonHigh.UseVisualStyleBackColor = true;
            // 
            // radioButtonMedium
            // 
            this.radioButtonMedium.AutoSize = true;
            this.radioButtonMedium.Location = new System.Drawing.Point(31, 70);
            this.radioButtonMedium.Name = "radioButtonMedium";
            this.radioButtonMedium.Size = new System.Drawing.Size(76, 20);
            this.radioButtonMedium.TabIndex = 1;
            this.radioButtonMedium.Text = "Medium";
            this.radioButtonMedium.UseVisualStyleBackColor = true;
            // 
            // radioButtonLow
            // 
            this.radioButtonLow.AutoSize = true;
            this.radioButtonLow.Checked = true;
            this.radioButtonLow.Location = new System.Drawing.Point(31, 32);
            this.radioButtonLow.Name = "radioButtonLow";
            this.radioButtonLow.Size = new System.Drawing.Size(52, 20);
            this.radioButtonLow.TabIndex = 0;
            this.radioButtonLow.TabStop = true;
            this.radioButtonLow.Text = "Low";
            this.radioButtonLow.UseVisualStyleBackColor = true;
            // 
            // FormSmpClientProducer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 459);
            this.Controls.Add(this.groupBoxMessages);
            this.Controls.Add(this.textBoxServerResponse);
            this.Controls.Add(this.labelServerResponse);
            this.Controls.Add(this.groupBoxSettings);
            this.Name = "FormSmpClientProducer";
            this.Text = "SMP Producer Client Version 1.0";
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.groupBoxMessages.ResumeLayout(false);
            this.groupBoxMessages.PerformLayout();
            this.groupBoxPriority.ResumeLayout(false);
            this.groupBoxPriority.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.TextBox textBoxApplicationPortNumber;
        private System.Windows.Forms.Label labelApplicationPortNumber;
        private System.Windows.Forms.TextBox textBoxServerIPAddress;
        private System.Windows.Forms.Label labelServerIPAddress;
        private System.Windows.Forms.Label labelServerResponse;
        private System.Windows.Forms.TextBox textBoxServerResponse;
        private System.Windows.Forms.GroupBox groupBoxMessages;
        private System.Windows.Forms.GroupBox groupBoxPriority;
        private System.Windows.Forms.RadioButton radioButtonMedium;
        private System.Windows.Forms.RadioButton radioButtonLow;
        private System.Windows.Forms.TextBox textBoxMessageContent;
        private System.Windows.Forms.Label labelMessageContent;
        private System.Windows.Forms.RadioButton radioButtonHigh;
        private System.Windows.Forms.Button buttonSendMessage;
    }
}