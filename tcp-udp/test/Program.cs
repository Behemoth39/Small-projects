namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool menu = true;

            while (menu)
            {
                Console.WriteLine("\nTCP SERVER: " + "OFF");  // implement 
                Console.WriteLine("UDP SERVER: " + "OFF");    // implement 
                Console.WriteLine("[1] Start TCP Server");
                Console.WriteLine("[2] Start UDP Server");
                Console.WriteLine("[3] Send TCP message");
                Console.WriteLine("[4] Send UDP message");
                Console.WriteLine("[5] Exit");
                Console.Write("Input: ");
                Int32.TryParse(Console.ReadLine(), out int num);
                try
                {
                    switch (num)
                    {
                        case 1:
                            TcpServer tcpserver = new TcpServer();
                            tcpserver.Start();
                            break;
                        case 2:
                            UdpServer udpserver = new UdpServer();
                            udpserver.Start();
                            break;
                        case 3:
                            Client tcpclient = new Client();
                            tcpclient.SendTcpMessage("TCP");
                            break;
                        case 4:
                            Client udpclient = new Client();
                            udpclient.SendUdpMessage("TCP");
                            break;
                        case 5:
                            menu = false;
                            break;
                        default:
                            Console.WriteLine("invalid choice");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}