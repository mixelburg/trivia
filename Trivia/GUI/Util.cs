using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    internal class Util
    {
        /// <summary>
        /// opens new Form and closes current (hides it)
        /// </summary>
        /// <param name="newForm">new Form to open</param>
        /// <param name="currForm">current Form to be closed</param>
        public static void OpenNewForm(Form newForm, Form currForm)
        {
            newForm.Location = currForm.Location;
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Closing += delegate { currForm.Close(); };
            newForm.Show();
            currForm.Hide();
        }

        /// <summary>
        /// sends request to the server using given socket and returns answer
        /// </summary>
        /// <param name="socket">socket to be user to send request</param>
        /// <param name="request">string with request to be send</param>
        /// <returns>string with response from server</returns>
        public static string SendRequest(Socket socket, string request)
        {
            var messageSent = Encoding.ASCII.GetBytes(request);
            socket.Send(messageSent);
            var messageReceived = new byte[1024];

            //receiving message
            var byteRecv = socket.Receive(messageReceived);

            Console.WriteLine(@"Message from Server -> {0}",
                Encoding.ASCII.GetString(messageReceived,
                    0, byteRecv));

            return Encoding.ASCII.GetString(messageReceived, 0, byteRecv);
        }
    }
}