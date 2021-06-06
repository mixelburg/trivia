using System;
using System.Net.Sockets;
using System.Windows.Forms;

namespace GUI.Forms.Menu
{
    public partial class BestScoresForm : Form
    {
        private Socket _socket;

        public BestScoresForm(ref Socket socket)
        {
            _socket = socket;
            InitializeComponent();
        }

        private void backMenuButton_Click(object sender, EventArgs e)
        {
            Util.OpenNewForm(new MenuForm(ref _socket), this);
        }

        private void BestScoresForm_Load(object sender, EventArgs e)
        {
            var stats = Deserializer.DeserializeScoresMsg(
                Util.SendRequest(_socket, CodesClass.getHighScoreCode + "0000")
            ).HighScores.Split(',');

            bestScoresListBox.DataSource = stats;
        }
    }
}