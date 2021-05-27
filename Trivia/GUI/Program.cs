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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            // Establish the remote endpoint 
            IPAddress ipAddr = Dns.Resolve("localhost").AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddr, 5050);

            // Creation TCP/IP Socket 
            Socket sender = new Socket(ipAddr.AddressFamily,
                       SocketType.Stream, ProtocolType.Tcp);

            Form toRun = new LoginForm(ref sender);

            // Connect Socket to the remote
            try
            {
                sender.Connect(localEndPoint);
            }
            catch (System.Net.Sockets.SocketException e)
            {
                Console.WriteLine(e.Message);
                toRun = new ConnectionErrorForm(e.Message);
            }

            Application.Run(toRun);
        }
    }
}
