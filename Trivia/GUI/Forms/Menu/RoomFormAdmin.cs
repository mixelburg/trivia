﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms.Menu
{
    public partial class RoomFormAdmin : Form
    {
        private Socket _socket;
        public RoomFormAdmin(ref Socket socket)
        {
            _socket = socket;
            InitializeComponent();
        }

        private void closeRoomButton_Click(object sender, EventArgs e)
        {
            
            Util.OpenNewForm(new MenuForm(ref _socket), this);
        }
    }
}
