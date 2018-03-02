using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitchLib;
using TwitchLib.Models.API;
using TwitchLib.Models.Client;
using TwitchLib.Events.Client;
using TwitchLib.Exceptions.API;
using TwitchLib.Events.PubSub;
using TwitchLib.Events.Services.FollowerService;
using TwitchLib.Events.Services.MessageThrottler;
using TwitchLib.Enums;
using TwitchLib.Extensions.Client;


namespace TrayChatBot
{
    public partial class MainForm : Form
    {
        public static string  twitchName = Properties.Settings.Default.login;
        public static string  oauthToken = Properties.Settings.Default.oauth;
        public TwitchClient client = new TwitchClient(new ConnectionCredentials(twitchName, oauthToken));

        public MainForm()
        {
            InitializeComponent();
        }

        private void mf_btnConnect_Click(object sender, EventArgs e)
        {
            // Проверка, подключен ли пользователь уже
            if(client.IsConnected)
            {
                print("ERROR: Connection is already established!");
                return;
            }
            // Проверка на пустое поле имени канала
            if(mf_txtChannelName.Text == "")
            {
                print("ERROR: Type channel name first!");
                return;
            }
            client.OnConnected += new EventHandler<OnConnectedArgs>(onConnected);
            client.Connect();
            mf_ChatBox.AppendText("Connecting...\n");
        }

        private void mf_btnChat_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)
            {
                mf_ChatBox.AppendText(mf_txtChatLineBox.Text + "\n");
                client.SendMessage(mf_txtChatLineBox.Text);
            }
            else
            {
                mf_ChatBox.AppendText("Error! Disconnected from chat!");
            }
        }

        private void mf_btnDisconnect_Click(object sender, EventArgs e)
        {
            client.Disconnect();
        }

        public void onConnected(object sender, OnConnectedArgs e)
        {
            client.OnDisconnected += new EventHandler<OnDisconnectedArgs>(onDisconnected);

            CheckForIllegalCrossThreadCalls = false;
            mf_ChatBox.AppendText("Connection established!\n");
            client.JoinChannel(mf_txtChannelName.Text);
        }

        public void onDisconnected(object sender, OnDisconnectedArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            mf_ChatBox.AppendText("Disconnected!\n");
            
        }
              
        public void print(string text)
        {
            mf_ChatBox.AppendText(text + "\n");
        }
    }
}
