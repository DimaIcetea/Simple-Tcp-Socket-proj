using System;
using System.Net;
using System.Net.Sockets;
using System.Text;


namespace TcpClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TCP
            const string IP = "127.0.0.1";
            const int PORT = 8080;

            var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            var tcpEndPoint = new IPEndPoint(IPAddress.Parse(IP), PORT);

            Console.WriteLine("Enter the message:");
            var message = Console.ReadLine();

            var data = Encoding.UTF8.GetBytes(message);

            tcpSocket.Connect(tcpEndPoint);
            tcpSocket.Send(data);

            var buffer = new byte[256];
            var trueSize = 0;
            var answer = new StringBuilder();

            do
            {
                trueSize = tcpSocket.Receive(buffer);
                answer.Append(Encoding.UTF8.GetString(buffer, 0, trueSize));
            }
            while (tcpSocket.Available > 0);

            Console.WriteLine(answer.ToString());
            tcpSocket.Shutdown(SocketShutdown.Both);
            tcpSocket.Close();
            Console.ReadLine();
            #endregion
        }
    }
}
