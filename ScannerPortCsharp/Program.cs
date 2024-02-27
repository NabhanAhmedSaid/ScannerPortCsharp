
using System.Net.Sockets;

List<int> list = new List<int>() { 80, 443, 21, 22, 110, 995, 143, 993, 25, 26, 587, 3306, 587, 500, 3389, 179, 123, 53 };
TcpClient Scan = new TcpClient();

Console.WriteLine("Enter The URL \n" +
    "Example google.com");

var IP = Console.ReadLine();


for (int i = 0; i < list.Count; i++)
{
    try
    {
        Scan.Connect(IP, list[i]);
        Console.WriteLine(list[i] + " port Open ");
    }
    catch
    {
        Console.WriteLine(list[i] + " Port Close");

    }
}
