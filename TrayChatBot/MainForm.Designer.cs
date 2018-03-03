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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.chnLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.chNameBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gameNameBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.communitiesBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mf_btnConnect
            // 
            this.mf_btnConnect.Location = new System.Drawing.Point(436, 444);
            this.mf_btnConnect.Name = "mf_btnConnect";
            this.mf_btnConnect.Size = new System.Drawing.Size(125, 24);
            this.mf_btnConnect.TabIndex = 0;
            this.mf_btnConnect.Text = "Connect";
            this.mf_btnConnect.UseVisualStyleBackColor = true;
            this.mf_btnConnect.Click += new System.EventHandler(this.mf_btnConnect_Click);
            // 
            // mf_btnDisconnect
            // 
            this.mf_btnDisconnect.Location = new System.Drawing.Point(578, 443);
            this.mf_btnDisconnect.Name = "mf_btnDisconnect";
            this.mf_btnDisconnect.Size = new System.Drawing.Size(121, 25);
            this.mf_btnDisconnect.TabIndex = 1;
            this.mf_btnDisconnect.Text = "Disconnect";
            this.mf_btnDisconnect.UseVisualStyleBackColor = true;
            this.mf_btnDisconnect.Click += new System.EventHandler(this.mf_btnDisconnect_Click);
            // 
            // mf_ChatBox
            // 
            this.mf_ChatBox.BackColor = System.Drawing.Color.White;
            this.mf_ChatBox.Location = new System.Drawing.Point(21, 109);
            this.mf_ChatBox.Name = "mf_ChatBox";
            this.mf_ChatBox.ReadOnly = true;
            this.mf_ChatBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.mf_ChatBox.Size = new System.Drawing.Size(380, 310);
            this.mf_ChatBox.TabIndex = 2;
            this.mf_ChatBox.Text = "";
            // 
            // mf_btnChat
            // 
            this.mf_btnChat.Location = new System.Drawing.Point(331, 434);
            this.mf_btnChat.Name = "mf_btnChat";
            this.mf_btnChat.Size = new System.Drawing.Size(69, 31);
            this.mf_btnChat.TabIndex = 4;
            this.mf_btnChat.Text = "Send";
            this.mf_btnChat.UseVisualStyleBackColor = false;
            this.mf_btnChat.Click += new System.EventHandler(this.mf_btnChat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Channel:";
            // 
            // mf_LogBox
            // 
            this.mf_LogBox.Location = new System.Drawing.Point(436, 110);
            this.mf_LogBox.Name = "mf_LogBox";
            this.mf_LogBox.ReadOnly = true;
            this.mf_LogBox.Size = new System.Drawing.Size(263, 309);
            this.mf_LogBox.TabIndex = 7;
            this.mf_LogBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(136, 93);
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
            this.label3.Location = new System.Drawing.Point(536, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "LOGBOX";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mf_btnJoin
            // 
            this.mf_btnJoin.Location = new System.Drawing.Point(436, 517);
            this.mf_btnJoin.Name = "mf_btnJoin";
            this.mf_btnJoin.Size = new System.Drawing.Size(125, 23);
            this.mf_btnJoin.TabIndex = 9;
            this.mf_btnJoin.Text = "Join";
            this.mf_btnJoin.UseVisualStyleBackColor = true;
            this.mf_btnJoin.Click += new System.EventHandler(this.mf_btnJoin_Click);
            // 
            // mf_btnLeave
            // 
            this.mf_btnLeave.Location = new System.Drawing.Point(578, 517);
            this.mf_btnLeave.Name = "mf_btnLeave";
            this.mf_btnLeave.Size = new System.Drawing.Size(121, 23);
            this.mf_btnLeave.TabIndex = 10;
            this.mf_btnLeave.Text = "Leave";
            this.mf_btnLeave.UseVisualStyleBackColor = true;
            this.mf_btnLeave.Click += new System.EventHandler(this.mf_btnLeave_Click);
            // 
            // mf_txtChannelName
            // 
            this.mf_txtChannelName.FormattingEnabled = true;
            this.mf_txtChannelName.Items.AddRange(new object[] {
            "a_couple_streams",
            "welovegames",
            "lirik",
            "stray228",
            "rxnexus",
            "dreadztv",
            "trayhardplay"});
            this.mf_txtChannelName.Location = new System.Drawing.Point(436, 492);
            this.mf_txtChannelName.Name = "mf_txtChannelName";
            this.mf_txtChannelName.Size = new System.Drawing.Size(235, 21);
            this.mf_txtChannelName.TabIndex = 11;
            this.mf_txtChannelName.Text = "a_couple_streams";
            // 
            // mf_txtChatLineBox
            // 
            this.mf_txtChatLineBox.Location = new System.Drawing.Point(21, 434);
            this.mf_txtChatLineBox.Name = "mf_txtChatLineBox";
            this.mf_txtChatLineBox.Size = new System.Drawing.Size(304, 108);
            this.mf_txtChatLineBox.TabIndex = 12;
            this.mf_txtChatLineBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "Clear Chat";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // chnLabel
            // 
            this.chnLabel.AutoSize = true;
            this.chnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chnLabel.Location = new System.Drawing.Point(12, 19);
            this.chnLabel.Name = "chnLabel";
            this.chnLabel.Size = new System.Drawing.Size(68, 16);
            this.chnLabel.TabIndex = 14;
            this.chnLabel.Text = "Channel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Server:";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(677, 492);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 23);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(331, 510);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 32);
            this.button3.TabIndex = 16;
            this.button3.Text = "Smiles";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // chNameBox
            // 
            this.chNameBox.Location = new System.Drawing.Point(86, 18);
            this.chNameBox.Name = "chNameBox";
            this.chNameBox.ReadOnly = true;
            this.chNameBox.Size = new System.Drawing.Size(273, 20);
            this.chNameBox.TabIndex = 17;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(18, 56);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(43, 16);
            this.titleLabel.TabIndex = 14;
            this.titleLabel.Text = "Title:";
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(86, 56);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.ReadOnly = true;
            this.TitleBox.Size = new System.Drawing.Size(314, 20);
            this.TitleBox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(433, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Game:";
            // 
            // gameNameBox
            // 
            this.gameNameBox.Location = new System.Drawing.Point(501, 56);
            this.gameNameBox.Name = "gameNameBox";
            this.gameNameBox.ReadOnly = true;
            this.gameNameBox.Size = new System.Drawing.Size(198, 20);
            this.gameNameBox.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(386, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Communities:";
            // 
            // communitiesBox
            // 
            this.communitiesBox.Location = new System.Drawing.Point(501, 19);
            this.communitiesBox.Name = "communitiesBox";
            this.communitiesBox.ReadOnly = true;
            this.communitiesBox.Size = new System.Drawing.Size(198, 20);
            this.communitiesBox.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 566);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.communitiesBox);
            this.Controls.Add(this.gameNameBox);
            this.Controls.Add(this.chNameBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.chnLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mf_txtChatLineBox);
            this.Controls.Add(this.mf_txtChannelName);
            this.Controls.Add(this.mf_btnLeave);
            this.Controls.Add(this.mf_btnJoin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mf_LogBox);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label chnLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox chNameBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox gameNameBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox communitiesBox;
    }
}

