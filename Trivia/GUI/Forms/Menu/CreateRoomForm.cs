using System;
using System.Drawing;
using System.Net.Sockets;
using System.Windows.Forms;

namespace GUI.Forms.Menu
{
    public partial class CreateRoomForm : Form
    {
        private Socket _socket;

        public CreateRoomForm(ref Socket socket)
        {
            _socket = socket;
            InitializeComponent();
        }

        private void backMenuButton_Click(object sender, EventArgs e)
        {
            Util.OpenNewForm(new MenuForm(ref _socket), this);
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            //create the create room data object to send
            var data = new CreateRoomData
            {
                name = roomNameTextBox.Text,
                maxUsers = int.Parse(numPlayersTextBox.Text),
                questionCount = int.Parse(numQuestionsTextBox.Text),
                answerTimeout = int.Parse(questionTimeTextBox.Text)
            };
            //serialize the object
            var request = Serializer.SerializeCreateRoomRequest(ref data);

            var msg = Util.SendRequest(_socket, request);

            var serverResponse = Deserializer.DeserializeStatusMsg(msg);
            //act by server's answer
            if (serverResponse.status == "0") // fail
            {
                statusLabel.Text = @"[!] CreateRoom Failed";
                statusLabel.ForeColor = Color.Red;
            }
            else
            {
                Util.OpenNewForm(new RoomFormAdmin(ref _socket), this);
            }
        }

        private void CreateRoomForm_Load(object sender, EventArgs e)
        {

        }
    }
}