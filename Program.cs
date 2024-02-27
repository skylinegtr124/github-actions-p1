﻿using System;

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
            while(true)
            {
                Thread.Sleep(1000); // Пауза в выполнении цикла на 1 секунду
            }
        }
    }
}
