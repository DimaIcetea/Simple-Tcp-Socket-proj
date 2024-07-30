using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TcpServer
{
    internal class Program
    {
        #region TCP
        static void Main(string[] args)
        {
            const string IP = "127.0.0.1";
            const int PORT = 8080;

            var tcpEndPoint = new IPEndPoint(IPAddress.Parse(IP), PORT);

            var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            tcpSocket.Bind(tcpEndPoint);
            tcpSocket.Listen(5);

            while (true)
            {
                var listener = tcpSocket.Accept();
                var buffer = new byte[256];
                var trueSize = 0;
                var data = new StringBuilder();

                do
                {
                    trueSize = listener.Receive(buffer);
                    data.Append(Encoding.UTF8.GetString(buffer, 0, trueSize));
                }
                while (listener.Available > 0);

                Console.WriteLine(data.ToString());

                listener.Send(Encoding.UTF8.GetBytes("successfully!"));

                listener.Shutdown(SocketShutdown.Both);
                listener.Close();
            }

        }
        #endregion
    }
}
