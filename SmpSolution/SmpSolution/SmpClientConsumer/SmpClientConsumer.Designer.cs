namespace SmpClientConsumer
{
    partial class FormSmpClientConsumer
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
            this.groupBoxMessage = new System.Windows.Forms.GroupBox();
            this.buttonGetMessage = new System.Windows.Forms.Button();
            this.textBoxMessageContent = new System.Windows.Forms.TextBox();
            this.labelMessageContent = new System.Windows.Forms.Label();
            this.groupBoxPriority = new System.Windows.Forms.GroupBox();
            this.radioButtonHigh = new System.Windows.Forms.RadioButton();
            this.radioButtonMedium = new System.Windows.Forms.RadioButton();
            this.radioButtonLow = new System.Windows.Forms.RadioButton();
            this.groupBoxSettings.SuspendLayout();
            this.groupBoxMessage.SuspendLayout();
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
            this.groupBoxSettings.Size = new System.Drawing.Size(555, 73);
            this.groupBoxSettings.TabIndex = 0;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Settings";
            // 
            // textBoxApplicationPortNumber
            // 
            this.textBoxApplicationPortNumber.Location = new System.Drawing.Point(429, 31);
            this.textBoxApplicationPortNumber.Name = "textBoxApplicationPortNumber";
            this.textBoxApplicationPortNumber.Size = new System.Drawing.Size(100, 22);
            this.textBoxApplicationPortNumber.TabIndex = 3;
            this.textBoxApplicationPortNumber.Text = "50400";
            this.textBoxApplicationPortNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelApplicationPortNumber
            // 
            this.labelApplicationPortNumber.AutoSize = true;
            this.labelApplicationPortNumber.Location = new System.Drawing.Point(271, 34);
            this.labelApplicationPortNumber.Name = "labelApplicationPortNumber";
            this.labelApplicationPortNumber.Size = new System.Drawing.Size(152, 16);
            this.labelApplicationPortNumber.TabIndex = 2;
            this.labelApplicationPortNumber.Text = "Application Port Number";
            // 
            // textBoxServerIPAddress
            // 
            this.textBoxServerIPAddress.Location = new System.Drawing.Point(143, 31);
            this.textBoxServerIPAddress.Name = "textBoxServerIPAddress";
            this.textBoxServerIPAddress.Size = new System.Drawing.Size(100, 22);
            this.textBoxServerIPAddress.TabIndex = 1;
            this.textBoxServerIPAddress.Text = "127.0.0.1";
            this.textBoxServerIPAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelServerIPAddress
            // 
            this.labelServerIPAddress.AutoSize = true;
            this.labelServerIPAddress.Location = new System.Drawing.Point(21, 34);
            this.labelServerIPAddress.Name = "labelServerIPAddress";
            this.labelServerIPAddress.Size = new System.Drawing.Size(116, 16);
            this.labelServerIPAddress.TabIndex = 0;
            this.labelServerIPAddress.Text = "Server IP Address";
            // 
            // groupBoxMessage
            // 
            this.groupBoxMessage.Controls.Add(this.buttonGetMessage);
            this.groupBoxMessage.Controls.Add(this.textBoxMessageContent);
            this.groupBoxMessage.Controls.Add(this.labelMessageContent);
            this.groupBoxMessage.Controls.Add(this.groupBoxPriority);
            this.groupBoxMessage.Location = new System.Drawing.Point(12, 104);
            this.groupBoxMessage.Name = "groupBoxMessage";
            this.groupBoxMessage.Size = new System.Drawing.Size(555, 301);
            this.groupBoxMessage.TabIndex = 1;
            this.groupBoxMessage.TabStop = false;
            this.groupBoxMessage.Text = "Message";
            // 
            // buttonGetMessage
            // 
            this.buttonGetMessage.Location = new System.Drawing.Point(239, 252);
            this.buttonGetMessage.Name = "buttonGetMessage";
            this.buttonGetMessage.Size = new System.Drawing.Size(238, 39);
            this.buttonGetMessage.TabIndex = 3;
            this.buttonGetMessage.Text = "Get Message";
            this.buttonGetMessage.UseVisualStyleBackColor = true;
            // 
            // textBoxMessageContent
            // 
            this.textBoxMessageContent.Location = new System.Drawing.Point(183, 66);
            this.textBoxMessageContent.Multiline = true;
            this.textBoxMessageContent.Name = "textBoxMessageContent";
            this.textBoxMessageContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxMessageContent.Size = new System.Drawing.Size(353, 167);
            this.textBoxMessageContent.TabIndex = 2;
            // 
            // labelMessageContent
            // 
            this.labelMessageContent.AutoSize = true;
            this.labelMessageContent.Location = new System.Drawing.Point(180, 36);
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
            this.groupBoxPriority.Location = new System.Drawing.Point(24, 36);
            this.groupBoxPriority.Name = "groupBoxPriority";
            this.groupBoxPriority.Size = new System.Drawing.Size(126, 163);
            this.groupBoxPriority.TabIndex = 0;
            this.groupBoxPriority.TabStop = false;
            this.groupBoxPriority.Text = "Priority";
            // 
            // radioButtonHigh
            // 
            this.radioButtonHigh.AutoSize = true;
            this.radioButtonHigh.Location = new System.Drawing.Point(23, 103);
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
            this.radioButtonMedium.Location = new System.Drawing.Point(23, 66);
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
            this.radioButtonLow.Location = new System.Drawing.Point(23, 30);
            this.radioButtonLow.Name = "radioButtonLow";
            this.radioButtonLow.Size = new System.Drawing.Size(52, 20);
            this.radioButtonLow.TabIndex = 0;
            this.radioButtonLow.TabStop = true;
            this.radioButtonLow.Text = "Low";
            this.radioButtonLow.UseVisualStyleBackColor = true;
            // 
            // FormSmpClientConsumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 417);
            this.Controls.Add(this.groupBoxMessage);
            this.Controls.Add(this.groupBoxSettings);
            this.Name = "FormSmpClientConsumer";
            this.Text = "SMP Consumer Client Version 1.0";
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.groupBoxMessage.ResumeLayout(false);
            this.groupBoxMessage.PerformLayout();
            this.groupBoxPriority.ResumeLayout(false);
            this.groupBoxPriority.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.Label labelApplicationPortNumber;
        private System.Windows.Forms.TextBox textBoxServerIPAddress;
        private System.Windows.Forms.Label labelServerIPAddress;
        private System.Windows.Forms.TextBox textBoxApplicationPortNumber;
        private System.Windows.Forms.GroupBox groupBoxMessage;
        private System.Windows.Forms.GroupBox groupBoxPriority;
        private System.Windows.Forms.RadioButton radioButtonHigh;
        private System.Windows.Forms.RadioButton radioButtonMedium;
        private System.Windows.Forms.RadioButton radioButtonLow;
        private System.Windows.Forms.Button buttonGetMessage;
        private System.Windows.Forms.TextBox textBoxMessageContent;
        private System.Windows.Forms.Label labelMessageContent;
    }
}