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
using GUI.Forms.Menu;

namespace GUI
{
    public partial class MenuForm : Form
    {
        private Socket _socket;
        public MenuForm(ref Socket socket)
        {
            _socket = socket;
            InitializeComponent();
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            // TODO: send logout request to server

            var newForm = new LoginForm(ref _socket)
            {
                Location = Location,
                StartPosition = FormStartPosition.Manual
            };
            newForm.Closing += delegate { Close(); };
            newForm.Show();
            Hide();
        }

        private void joinRoomButton_Click(object sender, EventArgs e)
        {
            var newForm = new JoinRoomForm(ref _socket)
            {
                Location = Location,
                StartPosition = FormStartPosition.Manual
            };
            newForm.Closing += delegate { Close(); };
            newForm.Show();
            Hide();
        }
    }
}
