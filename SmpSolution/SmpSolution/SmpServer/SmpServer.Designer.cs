namespace SmpServer
{
    partial class FormSmpServer
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
            this.startServerButton = new System.Windows.Forms.Button();
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.textBoxPortNumber = new System.Windows.Forms.TextBox();
            this.textBoxServerIPAddress = new System.Windows.Forms.TextBox();
            this.labelPortNumber = new System.Windows.Forms.Label();
            this.labelServerIPAddress = new System.Windows.Forms.Label();
            this.groupBoxLastRece = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelMessagePriority = new System.Windows.Forms.Label();
            this.textBoxMessageType = new System.Windows.Forms.TextBox();
            this.labelMessageType = new System.Windows.Forms.Label();
            this.groupBoxMessages = new System.Windows.Forms.GroupBox();
            this.buttonShowMessages = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBoxPriority = new System.Windows.Forms.GroupBox();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.radioButtonHigh = new System.Windows.Forms.RadioButton();
            this.radioButtonMedium = new System.Windows.Forms.RadioButton();
            this.radioButtonLow = new System.Windows.Forms.RadioButton();
            this.settingsGroupBox.SuspendLayout();
            this.groupBoxLastRece.SuspendLayout();
            this.groupBoxMessages.SuspendLayout();
            this.groupBoxPriority.SuspendLayout();
            this.SuspendLayout();
            // 
            // startServerButton
            // 
            this.startServerButton.Location = new System.Drawing.Point(25, 12);
            this.startServerButton.Name = "startServerButton";
            this.startServerButton.Size = new System.Drawing.Size(131, 116);
            this.startServerButton.TabIndex = 0;
            this.startServerButton.Text = "Start Server";
            this.startServerButton.UseVisualStyleBackColor = true;
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Controls.Add(this.textBoxPortNumber);
            this.settingsGroupBox.Controls.Add(this.textBoxServerIPAddress);
            this.settingsGroupBox.Controls.Add(this.labelPortNumber);
            this.settingsGroupBox.Controls.Add(this.labelServerIPAddress);
            this.settingsGroupBox.Location = new System.Drawing.Point(192, 12);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(411, 128);
            this.settingsGroupBox.TabIndex = 1;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Settings";
            // 
            // textBoxPortNumber
            // 
            this.textBoxPortNumber.Location = new System.Drawing.Point(174, 83);
            this.textBoxPortNumber.Name = "textBoxPortNumber";
            this.textBoxPortNumber.Size = new System.Drawing.Size(148, 22);
            this.textBoxPortNumber.TabIndex = 3;
            this.textBoxPortNumber.Text = "50400";
            this.textBoxPortNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxServerIPAddress
            // 
            this.textBoxServerIPAddress.Location = new System.Drawing.Point(174, 35);
            this.textBoxServerIPAddress.Name = "textBoxServerIPAddress";
            this.textBoxServerIPAddress.Size = new System.Drawing.Size(148, 22);
            this.textBoxServerIPAddress.TabIndex = 2;
            this.textBoxServerIPAddress.Text = "0.0.0.0";
            this.textBoxServerIPAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPortNumber
            // 
            this.labelPortNumber.AutoSize = true;
            this.labelPortNumber.Location = new System.Drawing.Point(38, 83);
            this.labelPortNumber.Name = "labelPortNumber";
            this.labelPortNumber.Size = new System.Drawing.Size(82, 16);
            this.labelPortNumber.TabIndex = 1;
            this.labelPortNumber.Text = "Port Number";
            // 
            // labelServerIPAddress
            // 
            this.labelServerIPAddress.AutoSize = true;
            this.labelServerIPAddress.Location = new System.Drawing.Point(38, 35);
            this.labelServerIPAddress.Name = "labelServerIPAddress";
            this.labelServerIPAddress.Size = new System.Drawing.Size(116, 16);
            this.labelServerIPAddress.TabIndex = 0;
            this.labelServerIPAddress.Text = "Server IP Address";
            // 
            // groupBoxLastRece
            // 
            this.groupBoxLastRece.Controls.Add(this.textBox1);
            this.groupBoxLastRece.Controls.Add(this.labelMessagePriority);
            this.groupBoxLastRece.Controls.Add(this.textBoxMessageType);
            this.groupBoxLastRece.Controls.Add(this.labelMessageType);
            this.groupBoxLastRece.Location = new System.Drawing.Point(12, 146);
            this.groupBoxLastRece.Name = "groupBoxLastRece";
            this.groupBoxLastRece.Size = new System.Drawing.Size(591, 72);
            this.groupBoxLastRece.TabIndex = 2;
            this.groupBoxLastRece.TabStop = false;
            this.groupBoxLastRece.Text = "Last Received Message";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(405, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelMessagePriority
            // 
            this.labelMessagePriority.AutoSize = true;
            this.labelMessagePriority.Location = new System.Drawing.Point(291, 34);
            this.labelMessagePriority.Name = "labelMessagePriority";
            this.labelMessagePriority.Size = new System.Drawing.Size(108, 16);
            this.labelMessagePriority.TabIndex = 1;
            this.labelMessagePriority.Text = "Message Priority";
            // 
            // textBoxMessageType
            // 
            this.textBoxMessageType.Location = new System.Drawing.Point(129, 31);
            this.textBoxMessageType.Name = "textBoxMessageType";
            this.textBoxMessageType.Size = new System.Drawing.Size(100, 22);
            this.textBoxMessageType.TabIndex = 2;
            this.textBoxMessageType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelMessageType
            // 
            this.labelMessageType.AutoSize = true;
            this.labelMessageType.Location = new System.Drawing.Point(24, 34);
            this.labelMessageType.Name = "labelMessageType";
            this.labelMessageType.Size = new System.Drawing.Size(99, 16);
            this.labelMessageType.TabIndex = 0;
            this.labelMessageType.Text = "Message Type";
            // 
            // groupBoxMessages
            // 
            this.groupBoxMessages.Controls.Add(this.buttonShowMessages);
            this.groupBoxMessages.Controls.Add(this.textBox2);
            this.groupBoxMessages.Controls.Add(this.groupBoxPriority);
            this.groupBoxMessages.Location = new System.Drawing.Point(12, 224);
            this.groupBoxMessages.Name = "groupBoxMessages";
            this.groupBoxMessages.Size = new System.Drawing.Size(591, 274);
            this.groupBoxMessages.TabIndex = 3;
            this.groupBoxMessages.TabStop = false;
            this.groupBoxMessages.Text = "Messages";
            // 
            // buttonShowMessages
            // 
            this.buttonShowMessages.Location = new System.Drawing.Point(166, 224);
            this.buttonShowMessages.Name = "buttonShowMessages";
            this.buttonShowMessages.Size = new System.Drawing.Size(233, 34);
            this.buttonShowMessages.TabIndex = 2;
            this.buttonShowMessages.Text = "Show Messages";
            this.buttonShowMessages.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(212, 21);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(355, 181);
            this.textBox2.TabIndex = 1;
            // 
            // groupBoxPriority
            // 
            this.groupBoxPriority.Controls.Add(this.radioButtonAll);
            this.groupBoxPriority.Controls.Add(this.radioButtonHigh);
            this.groupBoxPriority.Controls.Add(this.radioButtonMedium);
            this.groupBoxPriority.Controls.Add(this.radioButtonLow);
            this.groupBoxPriority.Location = new System.Drawing.Point(27, 21);
            this.groupBoxPriority.Name = "groupBoxPriority";
            this.groupBoxPriority.Size = new System.Drawing.Size(152, 181);
            this.groupBoxPriority.TabIndex = 0;
            this.groupBoxPriority.TabStop = false;
            this.groupBoxPriority.Text = "Priority";
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Location = new System.Drawing.Point(26, 141);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(43, 20);
            this.radioButtonAll.TabIndex = 3;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "All";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            // 
            // radioButtonHigh
            // 
            this.radioButtonHigh.AutoSize = true;
            this.radioButtonHigh.Location = new System.Drawing.Point(26, 104);
            this.radioButtonHigh.Name = "radioButtonHigh";
            this.radioButtonHigh.Size = new System.Drawing.Size(56, 20);
            this.radioButtonHigh.TabIndex = 2;
            this.radioButtonHigh.TabStop = true;
            this.radioButtonHigh.Text = "High";
            this.radioButtonHigh.UseVisualStyleBackColor = true;
            // 
            // radioButtonMedium
            // 
            this.radioButtonMedium.AutoSize = true;
            this.radioButtonMedium.Location = new System.Drawing.Point(26, 69);
            this.radioButtonMedium.Name = "radioButtonMedium";
            this.radioButtonMedium.Size = new System.Drawing.Size(76, 20);
            this.radioButtonMedium.TabIndex = 1;
            this.radioButtonMedium.TabStop = true;
            this.radioButtonMedium.Text = "Medium";
            this.radioButtonMedium.UseVisualStyleBackColor = true;
            // 
            // radioButtonLow
            // 
            this.radioButtonLow.AutoSize = true;
            this.radioButtonLow.Location = new System.Drawing.Point(26, 34);
            this.radioButtonLow.Name = "radioButtonLow";
            this.radioButtonLow.Size = new System.Drawing.Size(52, 20);
            this.radioButtonLow.TabIndex = 0;
            this.radioButtonLow.TabStop = true;
            this.radioButtonLow.Text = "Low";
            this.radioButtonLow.UseVisualStyleBackColor = true;
            // 
            // FormSmpServer
            // 
            this.ClientSize = new System.Drawing.Size(615, 510);
            this.Controls.Add(this.groupBoxMessages);
            this.Controls.Add(this.groupBoxLastRece);
            this.Controls.Add(this.settingsGroupBox);
            this.Controls.Add(this.startServerButton);
            this.Name = "FormSmpServer";
            this.Text = "SMP Server Version 1.0";
            this.settingsGroupBox.ResumeLayout(false);
            this.settingsGroupBox.PerformLayout();
            this.groupBoxLastRece.ResumeLayout(false);
            this.groupBoxLastRece.PerformLayout();
            this.groupBoxMessages.ResumeLayout(false);
            this.groupBoxMessages.PerformLayout();
            this.groupBoxPriority.ResumeLayout(false);
            this.groupBoxPriority.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Start_Server_Button;
        private System.Windows.Forms.Button startServerButton;
        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.Label labelServerIPAddress;
        private System.Windows.Forms.TextBox textBoxPortNumber;
        private System.Windows.Forms.TextBox textBoxServerIPAddress;
        private System.Windows.Forms.Label labelPortNumber;
        private System.Windows.Forms.GroupBox groupBoxLastRece;
        private System.Windows.Forms.TextBox textBoxMessageType;
        private System.Windows.Forms.Label labelMessagePriority;
        private System.Windows.Forms.Label labelMessageType;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxMessages;
        private System.Windows.Forms.GroupBox groupBoxPriority;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.RadioButton radioButtonHigh;
        private System.Windows.Forms.RadioButton radioButtonMedium;
        private System.Windows.Forms.RadioButton radioButtonLow;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonShowMessages;
    }
}

