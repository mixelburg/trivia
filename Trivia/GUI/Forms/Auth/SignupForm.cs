using System;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
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

        private void loginButton_Click(object sender, System.EventArgs e)
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

        private void signupButton_Click(object sender, System.EventArgs e)
        {
            SignupRequestData data = new SignupRequestData
            {
                username = textBoxUname.Text,
                password = textBoxPass.Text,
                mail = textBoxMail.Text
            };
            //serialize
            string request = Serializer.SerializeSignupRequest(ref data);
            
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
                statusLabel.Text = @"[!] Signup Failed - user with this name already exist!";
                statusLabel.ForeColor = Color.Red;
            }
            else
            {
                Util.OpenNewForm(new MenuForm(ref _socket), this);
            }

            Console.WriteLine(@"Message from Server -> {0}",
                Encoding.ASCII.GetString(messageReceived,
                    0, byteRecv));
        }

        }
    }


