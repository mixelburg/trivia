﻿using System;
using System.Net.Sockets;
using System.Windows.Forms;
using GUI.Forms.Menu;

namespace GUI
{
    public partial class MenuForm : Form
    {
        private Socket _socket;
        public MenuForm(ref Socket socket)
        {
            _socket = socket;
            InitializeComponent();
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            // TODO: send logout request to server

            Util.OpenNewForm(new LoginForm(ref _socket), this);
        }

        private void joinRoomButton_Click(object sender, EventArgs e)
        {
            Util.OpenNewForm(new JoinRoomForm(ref _socket), this);
        }

        private void createRoomButton_Click(object sender, EventArgs e)
        {
            Util.OpenNewForm(new CreateRoomForm(ref _socket), this);
        }

        private void myStatusButton_Click(object sender, EventArgs e)
        {
            Util.OpenNewForm(new MyStatus(ref _socket), this);
        }

        private void bestScoresButton_Click(object sender, EventArgs e)
        {
            Util.OpenNewForm(new BestScoresForm(ref _socket), this);
        }
    }
}
