using System.Net;
using Newtonsoft.Json;

public class Program
{
    static string API = "6bddde842f6a5bbd7fd3edc7fdcc9a88";
    static string initial = "Томск";

    public static void Main(string[] args)
    {
        weather(initial);
        Console.WriteLine("Введите название города:");
        string city = Console.ReadLine();

        weather(city);
    }

    private static void weather(string city)
    {
        string adress = $"http://api.openweathermap.org/data/2.5/find?q={city}&type=like&APPID={API}\r\n";

        using (WebClient client = new WebClient())
        {
            string load = client.DownloadString(adress);
        }
    }
}