using System.Text;
using System.Net;
using System.Net.Sockets;

namespace test
{
    public class UdpServer
    {
        public void Start()
        {
            UdpClient udpListener = new UdpClient(Settings.UDP_PORT);
            Console.WriteLine("UDP Server started. Waiting for messages...");
            while (true)
            {
                IPEndPoint clientEndPoint = new IPEndPoint(IPAddress.Any, Settings.UDP_PORT);
                byte[] buffer = udpListener.Receive(ref clientEndPoint);
                string message = Encoding.ASCII.GetString(buffer);
                Console.WriteLine("UDP Message received: " + message);
            }
        }
    }
}