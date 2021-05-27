using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            loginStatusLabel.Text = "[!] Login Failed \n incorrect username or password";
            loginStatusLabel.ForeColor = Color.Red;
          
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            var newForm = new SignupForm
            {
                Location = Location,
                StartPosition = FormStartPosition.Manual
            };
            newForm.FormClosing += delegate { Close(); };
            newForm.Show();
            Hide();
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUname_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
