using System;
using System.Net.Sockets;
using System.Windows.Forms;

namespace GUI.Forms.Menu
{
    public partial class MyStatus : Form
    {
        private Socket _socket;

        public MyStatus(ref Socket socket)
        {
            _socket = socket;
            InitializeComponent();
        }

        private void backMenuButton_Click(object sender, EventArgs e)
        {
            Util.OpenNewForm(new MenuForm(ref _socket), this);
        }

        private void MyStatus_Load(object sender, EventArgs e)
        {
            var stats = Deserializer.DeserializeUserStatsMsg(
                Util.SendRequest(_socket, CodesClass.getStatsCode + "0000")
            ).UserStatistics.Split(',');

            numGamesLabel.Text = stats[3];
            numRightLabel.Text = stats[1];
            numTotalLabel.Text = stats[2];
            avgTimeLabel.Text = stats[0];
        }
    }
}