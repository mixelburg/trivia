using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Establish the remote endpoint 
            IPAddress ipAddr = Dns.Resolve("localhost").AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddr, 5050);

            // Creation TCP/IP Socket 
            Socket sender = new Socket(ipAddr.AddressFamily,
                       SocketType.Stream, ProtocolType.Tcp);


            // Connect Socket to the remote 
            sender.Connect(localEndPoint);

            // We print EndPoint information 
            // that we are connected
            Console.WriteLine("Socket connected to -> {0} ",
                          sender.RemoteEndPoint.ToString());

            // Creation of messagge that
            // we will send to Server
            byte[] messageSent = Encoding.ASCII.GetBytes("Test Client<EOF>");
            int byteSent = sender.Send(messageSent);

            // Data buffer
            byte[] messageReceived = new byte[1024];

            int byteRecv = sender.Receive(messageReceived);
            Console.WriteLine("Message from Server -> {0}",
                  Encoding.ASCII.GetString(messageReceived,
                                             0, byteRecv));

            // Close Socket  
            Console.WriteLine("Closing socket");
            sender.Shutdown(SocketShutdown.Both);
            sender.Close();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
