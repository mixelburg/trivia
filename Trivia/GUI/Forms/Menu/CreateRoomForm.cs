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

        }
    }
}
