﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public struct LoginRequestData
    {
        public string uname;
        public string pass;
    }
    public struct SignupRequestData
    {
        public string uname;
        public string pass;
        public string mail;
    }


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
            statusLabel.Text = @"[!] Login Failed 
 incorrect username or password";
            statusLabel.ForeColor = Color.Red;

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
            Console.WriteLine(@"Message from Server -> {0}",
                Encoding.ASCII.GetString(messageReceived,
                    0, byteRecv));
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            var newForm = new SignupForm(ref _socket)
            {
                Location = Location,
                StartPosition = FormStartPosition.Manual
            };
            newForm.Closing += delegate { Close(); };
            newForm.Show();
            Hide();
        }
    }
}
