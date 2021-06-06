using System;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Windows;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
namespace GUI.Forms.Menu
{
    public partial class JoinRoomForm : Form
    {
        private Socket _socket;
        private const int SleepTimeMs = 2000;
        public JoinRoomForm(ref Socket socket)
        {
            _socket = socket;
            InitializeComponent();
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = (SleepTimeMs); // 2 secs
            timer.Tick += new EventHandler(JoinRoomForm_Load);
            timer.Start();
        }

        private void PrintNum(object sender, EventArgs r)
        {
            Console.WriteLine("hello world");
        }

        private void backMenuButton_Click(object sender, EventArgs e)
        {
            Util.OpenNewForm(new MenuForm(ref _socket), this);
        }

        private void JoinRoomForm_Load(object sender, EventArgs e)
        {
            roomsPanel.Controls.Clear();
            int i = 0;
            Deserializer.RoomsStruct rooms = getRooms();
            var namesList = rooms.roomsNames.Split(',');
            var idsList = rooms.roomsIds.Split(',');
            //creating map 
            SortedDictionary<string, int> roomMap = new SortedDictionary<string, int>();
            if (namesList[0] == "" || idsList[0] == "") {
                return;
            }
            for (i = 0; i < namesList.Length; ++i) {
                roomMap.Add(namesList[i], Int32.Parse(idsList[i])) ;
            }
            if (rooms.status == "1" && rooms.roomsNames != null) {
                for (i = 0; i < roomMap.Count; ++i)
                {
                    var b = new Button();
                    b.Width = 300;
                    b.Height = 35;
                    b.Text = namesList[i];
                    b.Click += (s, e) => { joinSpecRoom(roomMap[b.Text]); };
                    roomsPanel.Controls.Add(b);
                }
            }
        }
        private Deserializer.RoomsStruct getRooms() {
            string serverRes = Util.SendRequest(_socket, CodesClass.getRoomsCode + "0000");
             Deserializer.RoomsStruct rooms = Deserializer.DeserializeRoomsMsg(ref serverRes);
            return rooms;
        }
        private void joinSpecRoom(int id) {
            JoinRoomData joinRoomData = new JoinRoomData
            {
                roomId = id
            };
            string reqToServer = Serializer.SerializeJoinRoomRequest(ref joinRoomData);
            string serverResbeforDesi = Util.SendRequest(_socket, reqToServer);
            Deserializer.StatusStruct serverRes = Deserializer.DeserializeStatusMsg(serverResbeforDesi);
            // open roomMember form by id 
            if (serverRes.status == "0")
            {
                statusLabel.Text = @"[!] JoinRoom Failed";
                statusLabel.ForeColor = Color.Red;
            }
            else {
                Util.OpenNewForm(new RoomFormUser(ref _socket), this);
            }
        }
    
    }
}