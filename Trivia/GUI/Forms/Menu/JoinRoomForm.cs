using System;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Windows;

namespace GUI.Forms.Menu
{
    public partial class JoinRoomForm : Form
    {
        private Socket _socket;

        public JoinRoomForm(ref Socket socket)
        {
            _socket = socket;
            InitializeComponent();

            for (var i = 0; i < 2; i++)
            {
                var b = new Button();
                b.Width = 300;
                b.Height = 35;
                b.Text = "b" + i;
                b.Click +=
                    (o, e) => { Console.WriteLine("hello world"); };
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

        private void joinButton_Click(object sender, EventArgs e)
        {

        }
       
    }
}