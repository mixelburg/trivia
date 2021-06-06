using System;
using System.Net.Sockets;
using System.Windows.Forms;

namespace GUI.Forms.Menu
{
    public partial class RoomFormAdmin : Form
    {
        private int _roomId;
        private Socket _socket;
        private const int SleepTimeMs = 2000;
        public RoomFormAdmin(ref Socket socket, int roomId)
        {
            _roomId = roomId;
            _socket = socket;
            InitializeComponent();
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = (SleepTimeMs); // 2 secs
            timer.Tick += new EventHandler(RoomFormAdmin_Load);
            timer.Start();
        }

        private void closeRoomButton_Click(object sender, EventArgs e)
        {
            // close the room in the back end 
            Util.OpenNewForm(new MenuForm(ref _socket), this);
        }

        private void userListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            //send the server - Game started!!
        }

        private void RoomFormAdmin_Load(object sender, EventArgs e)
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
        private Deserializer.PlayersStruct getPlayers() {
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