using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            // Establish the remote endpoint 
            var ipAddr = Dns.Resolve("localhost").AddressList[0];
            var localEndPoint = new IPEndPoint(ipAddr, 5050);

            // Creation TCP/IP Socket 
            var sender = new Socket(ipAddr.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);

            Form toRun = new LoginForm(ref sender);

            // Connect Socket to the remote
            try
            {
                sender.Connect(localEndPoint);
                var messageReceived = new byte[1024];
                var byteRecv = sender.Receive(messageReceived);
                Console.WriteLine(@"Message from Server -> {0}",
                    Encoding.ASCII.GetString(messageReceived,
                        0, byteRecv));

                var request = "hello";

                var messageSent = Encoding.ASCII.GetBytes(request);
                sender.Send(messageSent);
            }
            catch (SocketException e)
            {
                Console.WriteLine(e.Message);
                toRun = new ConnectionErrorForm(e.Message);
            }

            Application.Run(toRun);
        }
    }
}