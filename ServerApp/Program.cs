using System;

namespace ServerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Database.Initialize();
            TCPServer server = new TCPServer(5000);
            server.Start();
        }
    }
}
