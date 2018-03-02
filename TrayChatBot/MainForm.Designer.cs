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
            this.mf_btnChat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mf_LogBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mf_btnJoin = new System.Windows.Forms.Button();
            this.mf_btnLeave = new System.Windows.Forms.Button();
            this.mf_txtChannelName = new System.Windows.Forms.ComboBox();
            this.mf_txtChatLineBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mf_btnConnect
            // 
            this.mf_btnConnect.Location = new System.Drawing.Point(344, 339);
            this.mf_btnConnect.Name = "mf_btnConnect";
            this.mf_btnConnect.Size = new System.Drawing.Size(85, 22);
            this.mf_btnConnect.TabIndex = 0;
            this.mf_btnConnect.Text = "Connect";
            this.mf_btnConnect.UseVisualStyleBackColor = true;
            this.mf_btnConnect.Click += new System.EventHandler(this.mf_btnConnect_Click);
            // 
            // mf_btnDisconnect
            // 
            this.mf_btnDisconnect.Location = new System.Drawing.Point(441, 338);
            this.mf_btnDisconnect.Name = "mf_btnDisconnect";
            this.mf_btnDisconnect.Size = new System.Drawing.Size(80, 23);
            this.mf_btnDisconnect.TabIndex = 1;
            this.mf_btnDisconnect.Text = "Disconnect";
            this.mf_btnDisconnect.UseVisualStyleBackColor = true;
            this.mf_btnDisconnect.Click += new System.EventHandler(this.mf_btnDisconnect_Click);
            // 
            // mf_ChatBox
            // 
            this.mf_ChatBox.BackColor = System.Drawing.Color.White;
            this.mf_ChatBox.Location = new System.Drawing.Point(12, 23);
            this.mf_ChatBox.Name = "mf_ChatBox";
            this.mf_ChatBox.ReadOnly = true;
            this.mf_ChatBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.mf_ChatBox.Size = new System.Drawing.Size(325, 310);
            this.mf_ChatBox.TabIndex = 2;
            this.mf_ChatBox.Text = "";
            // 
            // mf_btnChat
            // 
            this.mf_btnChat.Location = new System.Drawing.Point(268, 339);
            this.mf_btnChat.Name = "mf_btnChat";
            this.mf_btnChat.Size = new System.Drawing.Size(70, 40);
            this.mf_btnChat.TabIndex = 4;
            this.mf_btnChat.Text = "Send";
            this.mf_btnChat.UseVisualStyleBackColor = true;
            this.mf_btnChat.Click += new System.EventHandler(this.mf_btnChat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Channel:";
            // 
            // mf_LogBox
            // 
            this.mf_LogBox.Location = new System.Drawing.Point(344, 23);
            this.mf_LogBox.Name = "mf_LogBox";
            this.mf_LogBox.ReadOnly = true;
            this.mf_LogBox.Size = new System.Drawing.Size(176, 309);
            this.mf_LogBox.TabIndex = 7;
            this.mf_LogBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(139, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "CHATBOX";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(402, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "LOGBOX";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mf_btnJoin
            // 
            this.mf_btnJoin.Location = new System.Drawing.Point(344, 409);
            this.mf_btnJoin.Name = "mf_btnJoin";
            this.mf_btnJoin.Size = new System.Drawing.Size(85, 23);
            this.mf_btnJoin.TabIndex = 9;
            this.mf_btnJoin.Text = "Join";
            this.mf_btnJoin.UseVisualStyleBackColor = true;
            this.mf_btnJoin.Click += new System.EventHandler(this.mf_btnJoin_Click);
            // 
            // mf_btnLeave
            // 
            this.mf_btnLeave.Location = new System.Drawing.Point(441, 409);
            this.mf_btnLeave.Name = "mf_btnLeave";
            this.mf_btnLeave.Size = new System.Drawing.Size(79, 23);
            this.mf_btnLeave.TabIndex = 10;
            this.mf_btnLeave.Text = "Leave";
            this.mf_btnLeave.UseVisualStyleBackColor = true;
            this.mf_btnLeave.Click += new System.EventHandler(this.mf_btnLeave_Click);
            // 
            // mf_txtChannelName
            // 
            this.mf_txtChannelName.FormattingEnabled = true;
            this.mf_txtChannelName.Items.AddRange(new object[] {
            "welovegames",
            "lirik",
            "stray228",
            "rxnexus",
            "dreadztv",
            "trayhardplay"});
            this.mf_txtChannelName.Location = new System.Drawing.Point(344, 382);
            this.mf_txtChannelName.Name = "mf_txtChannelName";
            this.mf_txtChannelName.Size = new System.Drawing.Size(176, 21);
            this.mf_txtChannelName.TabIndex = 11;
            this.mf_txtChannelName.Text = "dreadztv";
            // 
            // mf_txtChatLineBox
            // 
            this.mf_txtChatLineBox.Location = new System.Drawing.Point(12, 341);
            this.mf_txtChatLineBox.Name = "mf_txtChatLineBox";
            this.mf_txtChatLineBox.Size = new System.Drawing.Size(249, 89);
            this.mf_txtChatLineBox.TabIndex = 12;
            this.mf_txtChatLineBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 44);
            this.button1.TabIndex = 13;
            this.button1.Text = "Clear Chat";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 442);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mf_txtChatLineBox);
            this.Controls.Add(this.mf_txtChannelName);
            this.Controls.Add(this.mf_btnLeave);
            this.Controls.Add(this.mf_btnJoin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mf_LogBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mf_btnChat);
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
        private System.Windows.Forms.Button mf_btnChat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox mf_LogBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button mf_btnJoin;
        private System.Windows.Forms.Button mf_btnLeave;
        private System.Windows.Forms.ComboBox mf_txtChannelName;
        private System.Windows.Forms.RichTextBox mf_txtChatLineBox;
        private System.Windows.Forms.Button button1;
    }
}

