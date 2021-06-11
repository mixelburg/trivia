using System.Windows.Forms;

namespace GUI
{
    public partial class ConnectionErrorForm : Form
    {
        public ConnectionErrorForm(string errorMessage)
        {
            InitializeComponent();
            label.Text = errorMessage;
        }
    }
}