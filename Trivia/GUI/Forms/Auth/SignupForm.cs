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

        }
    }

}
