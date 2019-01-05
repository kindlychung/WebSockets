using System;
using System.Net;

namespace WebSockets
{
    class Program
    {
        static void Main()
        {
            var server = new EchoServer(IPAddress.Loopback, 8002);
            server.Start();

            Console.WriteLine("Listening on 8002");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

            server.Stop();
        }
    }
}
