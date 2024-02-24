using System;

namespace BasicWebServer
{
    class Program
    {
        static void Main(string[] args)
        {
            string ipAddress = "127.0.0.1"; // IP-адрес, на котором будет запущен сервер
            int port = 8081; // Порт, на котором будет слушать сервер

            BasicWebServer.Server.HttpServer server = new BasicWebServer.Server.HttpServer(ipAddress, port);
            server.Start();

            Console.ReadLine(); // Добавляем для того, чтобы консоль не закрывалась сразу после запуска сервера
        }
    }
}