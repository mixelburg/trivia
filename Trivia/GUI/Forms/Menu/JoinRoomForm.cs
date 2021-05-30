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
    public partial class JoinRoomForm : Form
    {
        private Socket _socket;

        public JoinRoomForm(ref Socket socket)
        {
            _socket = socket;
            InitializeComponent();

            for (int i = 0; i < 2; i++)
            {
                Button b = new Button();
                b.Width = 300;
                b.Height = 35;
                b.Text = "b" + i;
                b.Click +=
                    (o, e) =>
                    {
                        Console.WriteLine("hello world");
                    };
                roomsPanel.Controls.Add(b);
            }
        }

        private void PrintNum(object sender, EventArgs r)
        {
            Console.WriteLine("hello world");
        }

        private void backMenuButton_Click(object sender, EventArgs e)
        {
            Util.OpenNewForm(new MenuForm(ref _socket), this);
        }
    }
}