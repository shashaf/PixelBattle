using ServerPB;
using System.Net;

var server = new GameServer();

// Выводим все доступные IP
Console.WriteLine("Сервер запущен. Доступные IP для подключения:");
foreach (var ip in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
{
    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
        Console.WriteLine($"  {ip}");
}

server.Start();

