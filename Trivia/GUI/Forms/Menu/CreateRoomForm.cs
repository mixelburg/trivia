using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
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
            CreateRoomData data = new CreateRoomData
            {
                name = roomNameTextBox.Text,
                maxUsers = Int32.Parse(numPlayersTextBox.Text),
                questionCount = Int32.Parse(numQuestionsTextBox.Text),
                answerTimeout = Int32.Parse(questionTimeTextBox.Text)
            };
            //serialize the object
            string request = Serializer.SerializeCreateRoomRequest(ref data);

            //sending message
            byte[] messageSent = Encoding.ASCII.GetBytes(request);
            _socket.Send(messageSent);
            byte[] messageReceived = new byte[1024];

            //receiveing message
            int byteRecv = _socket.Receive(messageReceived);
            string msg = Encoding.ASCII.GetString(messageReceived, 0, byteRecv);

            Deserializer.StatusStruct serverResponse = Deserializer.deserializeStatusMsg(ref msg);
            //act by server's answer
            if (serverResponse.status == "0") // fail
            {
                statusLabel.Text = @"[!] CreateRoom Failed";
                statusLabel.ForeColor = Color.Red;
            }
            else
            {
                // TO DO : change the form to the admin room form
                Util.OpenNewForm(new MenuForm(ref _socket), this);
            }

            Console.WriteLine(@"Message from Server about createRoom -> {0}",
                Encoding.ASCII.GetString(messageReceived,
                    0, byteRecv));
        }

    }
}
