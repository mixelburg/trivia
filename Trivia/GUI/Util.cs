using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    class Util
    {
        public static void OpenNewForm(Form newForm, Form currForm)
        {
            newForm.Location = currForm.Location;
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Closing += delegate { currForm.Close(); };
            newForm.Show();
            currForm.Hide();
        }
         
        public static string SendRequest(Socket socket, string request)
        {
            byte[] messageSent = Encoding.ASCII.GetBytes(request);
            socket.Send(messageSent);
            byte[] messageReceived = new byte[1024];

            //receiving message
            int byteRecv = socket.Receive(messageReceived);

            Console.WriteLine(@"Message from Server -> {0}",
                Encoding.ASCII.GetString(messageReceived,
                    0, byteRecv));

            return Encoding.ASCII.GetString(messageReceived, 0, byteRecv);
        }
    }
}
