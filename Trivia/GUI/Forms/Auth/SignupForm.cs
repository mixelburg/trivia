using System;
using System.Drawing;
using System.Net.Sockets;
using System.Windows.Forms;

namespace GUI
{
    public partial class SignupForm : Form
    {
        private Socket _socket;

        public SignupForm(ref Socket socket)
        {
            _socket = socket;
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var newForm = new LoginForm(ref _socket)
            {
                Location = Location,
                StartPosition = FormStartPosition.Manual
            };
            newForm.Closing += delegate { Close(); };
            newForm.Show();
            Hide();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            var data = new SignupRequestData
            {
                username = textBoxUname.Text,
                password = textBoxPass.Text,
                mail = textBoxMail.Text
            };
            //serialize
            var request = Serializer.SerializeSignupRequest(ref data);

            var msg = Util.SendRequest(_socket, request);

            var serverResponse = Deserializer.DeserializeStatusMsg(msg);
            //act by server's answer
            if (serverResponse.status == "0") // fail
            {
                statusLabel.Text = @"[!] Signup Failed - user with this name already exist!";
                statusLabel.ForeColor = Color.Red;
            }
            else
            {
                Util.OpenNewForm(new MenuForm(ref _socket), this);
            }
        }
    }
}