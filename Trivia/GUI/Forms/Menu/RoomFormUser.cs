using System;
using System.Net.Sockets;
using System.Windows.Forms;

namespace GUI.Forms.Menu
{
    public partial class RoomFormUser : Form
    {
        private Socket _socket;

        public RoomFormUser(ref Socket socket)
        {
            _socket = socket;
            InitializeComponent();
        }

        private void leaveRoomButton_Click(object sender, EventArgs e)
        {
            Util.OpenNewForm(new MenuForm(ref _socket), this);
        }
    }
}