using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitchLib;
using TwitchLib.Models.API;
using TwitchLib.Models.API.v5.Communities;
using TwitchLib.Models.Client;
using TwitchLib.Events.Client;

namespace TrayChatBot
{
    
    public partial class MainForm : Form
    {
        public static string  twitchName = Properties.Settings.Default.login;
        public static string  oauthToken = Properties.Settings.Default.oauth;
        public static string currChannel = "";
        public static string myName = "";
        public TwitchClient client = new TwitchClient(new ConnectionCredentials(twitchName, oauthToken));

        public MainForm()
        {
            InitializeComponent();
        }
        // КНОПКИ
        ////////////
        /// <summary>
        /// [кнопка] Connect server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mf_btnConnect_Click(object sender, EventArgs e)
        {
            // [CHECK] Подключен ли пользователь уже к серверу Twitch?
            if(client.IsConnected)
            {
                // [ДА] Вывод ошибки
                printError("Connection is already established!");
                return;
            }
            // [CHECK] Заполнено ли поле "ChannelName"?
            if (mf_txtChannelName.Text == "")
            {
                // [НЕТ] Вывод ошибки
                printError("Type channel name first!");
                return;
            }
            // Подключаемся к серверу
            client.OnConnected += new EventHandler<OnConnectedArgs>(onConnected);
            client.OnConnectionError += new EventHandler<OnConnectionErrorArgs>(onConnectionError);
            client.Connect();
            printInfo("Connecting...");
        }
        /// <summary>
        /// [кнопка] Disconnect server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mf_btnDisconnect_Click(object sender, EventArgs e)
        {
            // [CHECK] Подключен ли пользователь к чату?
            if (currChannel != "")
            {
                // [ДА] Отключаемся от этого чата
                client.LeaveChannel(currChannel);
                currChannel = "";
            }
            client.Disconnect();
        }
        /// <summary>
        /// [кнопка] Join channel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void mf_btnJoin_Click(object sender, EventArgs e)
        {
            // [CHECK] Подключен ли пользователь к серверу?
            if (!client.IsConnected)
            {
                // [НЕТ] Вывод ошибки
                printError("You are not connected to Twitch server. Press 'Connect' first!");
                return;
            }
            // [CHECK] Подключен ли пользователь к другим чатам?
            if(currChannel != "")
            {
                // [ДА] Вывод ошибки
                printError("You already joined channel '"+ currChannel +"'! Leave the channel first.");
                return;
            }
            // Подключаемся к каналу
            client.JoinChannel(mf_txtChannelName.Text);
            client.OnJoinedChannel += new EventHandler<OnJoinedChannelArgs>(onChannelJoined);
        }
        /// <summary>
        /// [кнопка] Leave channel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mf_btnLeave_Click(object sender, EventArgs e)
        {
            // Проверка подключен ли к серверу
            if (!client.IsConnected)
            {
                printError("You are not connected to Twitch server. Press 'Connect' first!");
                return;
            }
            // Проверка, подключен ли пользователь к чатам
            if (client.JoinedChannels.Count == 0)
            {
                printError("You are not joined to any channel!");
                return;
            }
            // Покидаем канал
            client.LeaveChannel(currChannel);
            client.OnLeftChannel += new EventHandler<OnLeftChannelArgs>(onChannelLeft);
        }
        /// <summary>
        /// [кнопка] Send
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mf_btnChat_Click(object sender, EventArgs e)
        {
            // [CHECK 1] Подключен ли пользователь к серверу?
            if (client.IsConnected)
            {
                // [CHECK 2] Подключен ли пользователь к каналу?
                if (currChannel != "")
                {
                    // [ДА] [ДА] Добавляем сообщение в чатбокс 
                    print(myName + ": " + mf_txtChatLineBox.Text);
                    // Отправляем его по установленному соединению
                    client.SendMessage(mf_txtChatLineBox.Text);
                    // Очищаем бокс с набираемым сообщением
                    mf_txtChatLineBox.Text = "";
                }
                else
                {
                    // [ДА] [НЕТ] Вывод ошибки
                    printError("You are not joined to any channel!");
                }
            }
            else
            {
                // [НЕТ] [...] Вывод ошибки
                printError("You are not connected to the server!");
            }
        }
        // HANDLER'ы
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

            myName = e.BotUsername;
            // Подключаемся к чату канала
            printInfo("Connection established!");

            client.OnMessageReceived += new EventHandler<OnMessageReceivedArgs>(globalMessageRecieved);
        }
        /// <summary>
        /// [handler] ОШИБКА подключения к серверу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void onConnectionError(object sender, OnConnectionErrorArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            printError("Connection failed! " + e.Error.Exception.Message);
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
        /// [handler] ЗАЙТИ на канал
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public async void onChannelJoined(object sender, OnJoinedChannelArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            currChannel = mf_txtChannelName.Text;
            printInfo("Succefully joined to channel '" + currChannel + "'!");
            try
            {
                var chanInfo = await getChannelInfo(currChannel);
                chNameBox.Text = currChannel.ToUpper();
                //printInfo("Title: " + chanInfo.broadcastTitle);
                TitleBox.Text = chanInfo.broadcastTitle;
                //printInfo("Game: " + chanInfo.gameName);
                gameNameBox.Text = chanInfo.gameName;
                //printInfo("Communities: " + chanInfo.communities);
                communitiesBox.Text = chanInfo.communities;
            }
            catch
            {
                printWarn("WARNING! You can't take any info about channel while it's offline.");
            }
            client.OnJoinedChannel -= onChannelJoined;
        }
        /// <summary>
        /// [handler] ПОКИНУТЬ канал
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void onChannelLeft(object sender, OnLeftChannelArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            printInfo("Succefully left channel '" + currChannel + "'!");
            currChannel = "";
            client.OnLeftChannel -= onChannelLeft;
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
            mf_ChatBox.Select(mf_ChatBox.Text.Length - (e.ChatMessage.DisplayName.Length + 1), e.ChatMessage.DisplayName.Length + 1);
            mf_ChatBox.SelectionFont = new Font(
                // Стиль никнейма
                "Tahoma", 
                10, 
                FontStyle.Bold
                );
            mf_ChatBox.SelectionColor = nameColor;
            print(" " + e.ChatMessage.Message);
            mf_ChatBox.Select(mf_ChatBox.Text.Length - (e.ChatMessage.Message.Length + 1), e.ChatMessage.Message.Length + 2);
            mf_ChatBox.SelectionFont = new Font(
                // Стиль сообщения
                "Tahoma",
                10,
                FontStyle.Regular
                );
            mf_ChatBox.SelectionColor = Color.Black;
            mf_ChatBox.SelectionStart = mf_ChatBox.TextLength;
            mf_ChatBox.ScrollToCaret();
        }
        // ФУНКЦИИ
        //////////////////
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
            mf_LogBox.AppendText("ERROR: "+text);
            mf_LogBox.Select(mf_LogBox.Text.Length - (text.Length + 7), (text.Length + 7));
            mf_LogBox.SelectionColor = Color.Red;
            mf_LogBox.AppendText("\n");
            mf_LogBox.ScrollToCaret();
        }
        /// <summary>
        /// [функция] Написать в чатбокс (ИНФО)
        /// </summary>
        /// <param name="text"></param>
        public void printInfo(string text)
        {
            mf_LogBox.AppendText(text);
            mf_LogBox.Select(mf_LogBox.Text.Length - text.Length, text.Length);
            mf_LogBox.SelectionColor = Color.BlueViolet;
            mf_LogBox.AppendText("\n");
            mf_LogBox.ScrollToCaret();
        }
        /// <summary>
        /// [функция] Написать в чатбокс (WARNING)
        /// </summary>
        /// <param name="text"></param>
        public void printWarn(string text)
        {
            mf_LogBox.AppendText("WARNING: "+text);
            mf_LogBox.Select(mf_LogBox.Text.Length - (text.Length + 9), (text.Length + 9));
            mf_LogBox.SelectionColor = Color.YellowGreen;
            mf_LogBox.AppendText("\n");
            mf_LogBox.ScrollToCaret();
        }
        /// <summary>
        /// Получить информацию о канале
        /// </summary>
        /// <param name="channel">Имя канала</param>
        /// <returns>Title, Game, Communities</returns>
        public async Task<(string broadcastTitle, string gameName, string communities)> getChannelInfo(string channel)
        {
            var api = new TwitchAPI();
            api.Settings.Validators.SkipAccessTokenValidation = true;
            api.Settings.Validators.SkipClientIdValidation = true;
            api.Settings.ClientId = Properties.Settings.Default.clientid;
            api.Settings.AccessToken = Properties.Settings.Default.apptoken;

            var User = await api.Users.v5.GetUserByNameAsync(channel);
            var Stream = await api.Streams.v5.GetStreamByUserAsync(User.Matches[0].Id);
            var communities = await api.Channels.v5.GetChannelCommuntiesAsync(User.Matches[0].Id);
            var CommunityString = "";
            if (communities.Communities.Length != 0)
            {
                foreach (Community comm in communities.Communities)
                    CommunityString += comm.Name + ", ";
                CommunityString = CommunityString.Remove(CommunityString.Length - 2, 2);
            }
            else
            {
                CommunityString = "No communities!";
            }
            return (Stream.Stream.Channel.Status, Stream.Stream.Channel.Game, CommunityString);
        }

        
    }
}
