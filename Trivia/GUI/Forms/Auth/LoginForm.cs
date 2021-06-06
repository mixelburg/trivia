using System;
using System.Drawing;
using System.Net.Sockets;
using System.Windows.Forms;

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
            var data = new LoginRequestData
            {
                username = textBoxUname.Text,
                password = textBoxPass.Text
            };
            //serialize
            var request = Serializer.SerializeLoginRequest(ref data);

            var msg = Util.SendRequest(_socket, request);

            var serverResponse = Deserializer.DeserializeStatusMsg(msg);
            //act by server's answer
            if (serverResponse.status == "0") // fail
            {
                statusLabel.Text = @"[!] Login Failed incorrect username or password";
                statusLabel.ForeColor = Color.Red;
            }
            else
            {
                Util.OpenNewForm(new MenuForm(ref _socket), this);
            }
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            Util.OpenNewForm(new SignupForm(ref _socket), this);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}