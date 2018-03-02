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
        public static string currChannel = "";
        public TwitchClient client = new TwitchClient(new ConnectionCredentials(twitchName, oauthToken));

        public MainForm()
        {
            InitializeComponent();
        }
        // КНОПКИ
        ////////////
        /// <summary>
        /// [кнопка] Connect
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mf_btnConnect_Click(object sender, EventArgs e)
        {
            // Проверка, подключен ли пользователь уже
            if(client.IsConnected)
            {
                printError("ERROR: Connection is already established!");
                return;
            }
            // Проверка на пустое поле имени канала
            if(mf_txtChannelName.Text == "")
            {
                printError("ERROR: Type channel name first!");
                return;
            }
            client.OnConnected += new EventHandler<OnConnectedArgs>(onConnected);
            client.Connect();
            printInfo("Connecting...");
        }
        /// <summary>
        /// [кнопка] Chat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mf_btnChat_Click(object sender, EventArgs e)
        {
            // Проверка если подключен то пишет в чат
            if (client.IsConnected)
            {
                print(client.TwitchUsername + ": " + mf_txtChatLineBox.Text);
                client.SendMessage(mf_txtChatLineBox.Text);
                mf_txtChatLineBox.Text = "";
            }
            // Если нет, то выдает ошибку
            else
            {
                printError("ERROR: You are not connected!");
            }
        }
        /// <summary>
        /// [кнопка] Disconnect
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mf_btnDisconnect_Click(object sender, EventArgs e)
        {
            client.Disconnect();
        }
        // ФУНКЦИИ
        /////////////
        /// <summary>
        /// [handler] ПОДКЛЮЧЕНИЕ к серверу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void onConnected(object sender, OnConnectedArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            client.OnDisconnected += new EventHandler<OnDisconnectedArgs>(onDisconnected);
            client.OnConnected -= onConnected;
            
            // Подключаемся к чату канала
            client.JoinChannel(mf_txtChannelName.Text);
            currChannel = mf_txtChannelName.Text;
            printInfo("Connection established!\n");

            client.OnMessageReceived += new EventHandler<OnMessageReceivedArgs>(globalMessageRecieved);
        }
        /// <summary>
        /// [handler] ОТКЛЮЧЕНИЕ от сервера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void onDisconnected(object sender, OnDisconnectedArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            client.LeaveChannel(currChannel);
            client.OnDisconnected -= onDisconnected;
            client.OnMessageReceived -= globalMessageRecieved;

            printInfo("Disconnected!");
        }
        /// <summary>
        /// [handler] Получение нового сообщения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void globalMessageRecieved(object sender, OnMessageReceivedArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Color nameColor = Color.FromArgb(e.ChatMessage.Color.R, e.ChatMessage.Color.G, e.ChatMessage.Color.B);
            
            mf_ChatBox.AppendText(e.ChatMessage.DisplayName + ":");
            mf_ChatBox.Select(mf_ChatBox.Text.Length - (e.ChatMessage.DisplayName.Length + 2), e.ChatMessage.DisplayName.Length + 2);
            mf_ChatBox.SelectionFont = new Font(
                "Tahoma", 
                10, 
                FontStyle.Bold
                );
            mf_ChatBox.SelectionColor = nameColor;
            print(" " + e.ChatMessage.Message);
            mf_ChatBox.Select(mf_ChatBox.Text.Length - (e.ChatMessage.Message.Length + 1), e.ChatMessage.Message.Length + 2);
            mf_ChatBox.SelectionFont = new Font(
                "Tahoma",
                10,
                FontStyle.Regular
                );
            mf_ChatBox.SelectionColor = Color.Black;
            mf_ChatBox.SelectionStart = mf_ChatBox.TextLength;
            mf_ChatBox.ScrollToCaret();
        }

        /// <summary>
        /// [функция] Написать в чатбокс
        /// </summary>
        /// <param name="text"></param>
        public void print(string text)
        {
            mf_ChatBox.Focus();
            mf_ChatBox.AppendText(text+ "\n");
        }
        /// <summary>
        /// [функция] Написать в чатбокс (ОШИБКА)
        /// </summary>
        /// <param name="text"></param>
        public void printError(string text)
        {
            mf_ChatBox.Focus();
            mf_ChatBox.AppendText(text);
            mf_ChatBox.Select(mf_ChatBox.Text.Length - text.Length, text.Length);
            mf_ChatBox.SelectionColor = Color.Red;
            mf_ChatBox.AppendText("\n");
        }
        /// <summary>
        /// [функция] Написать в чатбокс (ИНФО)
        /// </summary>
        /// <param name="text"></param>
        public void printInfo(string text)
        {
            mf_ChatBox.Focus();
            mf_ChatBox.AppendText(text);
            mf_ChatBox.Select(mf_ChatBox.Text.Length - text.Length, text.Length);
            mf_ChatBox.SelectionColor = Color.BlueViolet;
            mf_ChatBox.AppendText("\n");
        }
    }
}
