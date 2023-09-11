using System.Text;
using System.Net;
using System.Net.Sockets;

namespace test
{
    public class Client
    {
        public void SendTcpMessage(string message)
        {
            TcpClient tcpClient = new TcpClient();
            tcpClient.Connect(IPAddress.Loopback, Settings.TCP_PORT);
            NetworkStream stream = tcpClient.GetStream();
            byte[] data = Encoding.ASCII.GetBytes(message);
            stream.Write(data, 0, data.Length);
            Console.WriteLine("TCP Message sent: " + message);
            stream.Close();
            tcpClient.Close();
        }

        public void SendUdpMessage(string message)
        {
            UdpClient udpClient = new UdpClient();
            IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Loopback, Settings.UDP_PORT);
            byte[] data = Encoding.ASCII.GetBytes(message);
            udpClient.Send(data, data.Length, serverEndPoint);
            Console.WriteLine("UDP Message sent: " + message);
            udpClient.Close();
        }
    }
}