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
            print("Connecting...");
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
            }
            // Если нет, то выдает ошибку
            else
            {
                print("ERROR: You are not connected!");
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
            print("Connection established!\n");

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

            client.OnDisconnected -= onDisconnected;
            print("Disconnected!");
        }
        /// <summary>
        /// [handler] Получение нового сообщения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void globalMessageRecieved(object sender, OnMessageReceivedArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            print(e.ChatMessage.DisplayName + ": " + e.ChatMessage.Message);
        }

        /// <summary>
        /// [функция] Написать в чатбокс
        /// </summary>
        /// <param name="text"></param>
        public void print(string text)
        {
            mf_ChatBox.AppendText(text + "\n");
        }
    }
}
