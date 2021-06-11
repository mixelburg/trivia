using System;
using System.Net.Sockets;
using System.Windows.Forms;

namespace GUI.Forms.Menu
{
    public partial class RoomFormUser : Form
    {
        private Socket _socket;
        private int _roomId;
        private const int SleepTimeMs = 2000;
        public RoomFormUser(ref Socket socket, int roomId)
        {
            roomId = roomId;
            _socket = socket;
            InitializeComponent();
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = (SleepTimeMs); // 2 secs
            timer.Tick += new EventHandler(RoomFormUser_Load);
            timer.Start();
        }

        private void leaveRoomButton_Click(object sender, EventArgs e)
        {
            Util.OpenNewForm(new MenuForm(ref _socket), this);
        }

        private void RoomFormUser_Load(object sender, EventArgs e)
        {
            Console.WriteLine("loaded");
            //load players in room 
            Deserializer.PlayersStruct players = getPlayers();
            var splittedUsers = players.PlayersInRoom.Split(',');
            userListBox.Items.Clear();
            foreach (string user in splittedUsers)
            {
                userListBox.Items.Add(user);
            }
        }
        private Deserializer.PlayersStruct getPlayers()
        {
            GetPlayersData getPlayersData = new GetPlayersData
            {
                roomId = _roomId
            };
            string reqToServer = Serializer.SerializeGetPlayersRequest(ref getPlayersData);
            string serverRes = Util.SendRequest(_socket, reqToServer);
            Deserializer.PlayersStruct players = Deserializer.DeserializePlayersMsg(ref serverRes);
            return players;
        }
    }
}