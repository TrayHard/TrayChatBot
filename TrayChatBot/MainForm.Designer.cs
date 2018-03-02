namespace TrayChatBot
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mf_btnConnect = new System.Windows.Forms.Button();
            this.mf_btnDisconnect = new System.Windows.Forms.Button();
            this.mf_ChatBox = new System.Windows.Forms.RichTextBox();
            this.mf_txtChatLineBox = new System.Windows.Forms.TextBox();
            this.mf_btnChat = new System.Windows.Forms.Button();
            this.mf_txtChannelName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mf_btnConnect
            // 
            this.mf_btnConnect.Location = new System.Drawing.Point(12, 356);
            this.mf_btnConnect.Name = "mf_btnConnect";
            this.mf_btnConnect.Size = new System.Drawing.Size(154, 47);
            this.mf_btnConnect.TabIndex = 0;
            this.mf_btnConnect.Text = "Connect";
            this.mf_btnConnect.UseVisualStyleBackColor = true;
            this.mf_btnConnect.Click += new System.EventHandler(this.mf_btnConnect_Click);
            // 
            // mf_btnDisconnect
            // 
            this.mf_btnDisconnect.Location = new System.Drawing.Point(172, 356);
            this.mf_btnDisconnect.Name = "mf_btnDisconnect";
            this.mf_btnDisconnect.Size = new System.Drawing.Size(166, 47);
            this.mf_btnDisconnect.TabIndex = 1;
            this.mf_btnDisconnect.Text = "Disconnect";
            this.mf_btnDisconnect.UseVisualStyleBackColor = true;
            this.mf_btnDisconnect.Click += new System.EventHandler(this.mf_btnDisconnect_Click);
            // 
            // mf_ChatBox
            // 
            this.mf_ChatBox.BackColor = System.Drawing.Color.White;
            this.mf_ChatBox.Location = new System.Drawing.Point(13, 13);
            this.mf_ChatBox.Name = "mf_ChatBox";
            this.mf_ChatBox.ReadOnly = true;
            this.mf_ChatBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.mf_ChatBox.Size = new System.Drawing.Size(325, 258);
            this.mf_ChatBox.TabIndex = 2;
            this.mf_ChatBox.Text = "";
            // 
            // mf_txtChatLineBox
            // 
            this.mf_txtChatLineBox.Location = new System.Drawing.Point(13, 278);
            this.mf_txtChatLineBox.Name = "mf_txtChatLineBox";
            this.mf_txtChatLineBox.Size = new System.Drawing.Size(325, 20);
            this.mf_txtChatLineBox.TabIndex = 3;
            // 
            // mf_btnChat
            // 
            this.mf_btnChat.Location = new System.Drawing.Point(12, 305);
            this.mf_btnChat.Name = "mf_btnChat";
            this.mf_btnChat.Size = new System.Drawing.Size(326, 45);
            this.mf_btnChat.TabIndex = 4;
            this.mf_btnChat.Text = "Send";
            this.mf_btnChat.UseVisualStyleBackColor = true;
            this.mf_btnChat.Click += new System.EventHandler(this.mf_btnChat_Click);
            // 
            // mf_txtChannelName
            // 
            this.mf_txtChannelName.Location = new System.Drawing.Point(13, 416);
            this.mf_txtChannelName.Name = "mf_txtChannelName";
            this.mf_txtChannelName.Size = new System.Drawing.Size(153, 20);
            this.mf_txtChannelName.TabIndex = 5;
            this.mf_txtChannelName.Text = "lirik";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "< - Channel name";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 448);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mf_txtChannelName);
            this.Controls.Add(this.mf_btnChat);
            this.Controls.Add(this.mf_txtChatLineBox);
            this.Controls.Add(this.mf_ChatBox);
            this.Controls.Add(this.mf_btnDisconnect);
            this.Controls.Add(this.mf_btnConnect);
            this.Name = "MainForm";
            this.Text = "TrayChatBot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mf_btnConnect;
        private System.Windows.Forms.Button mf_btnDisconnect;
        private System.Windows.Forms.RichTextBox mf_ChatBox;
        private System.Windows.Forms.TextBox mf_txtChatLineBox;
        private System.Windows.Forms.Button mf_btnChat;
        private System.Windows.Forms.TextBox mf_txtChannelName;
        private System.Windows.Forms.Label label1;
    }
}

