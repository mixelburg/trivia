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
