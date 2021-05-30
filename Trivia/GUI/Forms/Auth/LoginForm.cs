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

    public partial class LoginForm : Form
    {
        private Socket _socket;
        public LoginForm(ref Socket socket)
        {
            _socket = socket;
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            LoginRequestData data = new LoginRequestData
            {
                uname = textBoxUname.Text,
                pass = textBoxPass.Text
            };
            string request = Serializer.SerializeLoginRequest(data);
            
            byte[] messageSent = Encoding.ASCII.GetBytes(request);
            _socket.Send(messageSent);
            byte[] messageReceived = new byte[1024];

            int byteRecv = _socket.Receive(messageReceived);
            string msg = Encoding.ASCII.GetString(messageReceived, 0, byteRecv);
            if (msg[0] == '0')
            {
                statusLabel.Text = @"[!] Login Failed 
    incorrect username or password";
                statusLabel.ForeColor = Color.Red;
            }

            Console.WriteLine(@"Message from Server -> {0}",
                Encoding.ASCII.GetString(messageReceived,
                    0, byteRecv));
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            Util.OpenNewForm(new SignupForm(ref _socket), this);
        }
    }
}
