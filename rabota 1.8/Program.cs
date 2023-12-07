using System.Net;
using System.Text.Json.Nodes;

public class Program
{
    static void Main(string[] args)
    {
        string town = "";
        if (args.Length == 0)
        {
            town = File.ReadAllText("town.txt");
        }
        else
        {
            town = args[0];
            Console.WriteLine($"Хотите сделать город {town} городом по умолчанию? (Yes/No)");
            if (Console.ReadLine() == "Yes")
            {
                File.WriteAllText("town.txt", town);
            }
        }

        var request = WebRequest.Create($"https://geocode-maps.yandex.ru/1.x/?apikey=db396852-b7d4-476f-a1f9-4055bba4be43&geocode={town}&format=json");
        var response = request.GetResponse();
        Stream stream = response.GetResponseStream();
        StreamReader reader = new StreamReader(stream);
        string jsonString = reader.ReadToEnd();
        response.Close();
        int i = int.Parse("32");
        var jsonCoordinates = JsonObject.Parse(jsonString);
        string[] coordinates = jsonCoordinates["response"]["GeoObjectCollection"]["featureMember"][0]["GeoObject"]["Point"]["pos"]
            .ToString().Split(' ');
        

        request = WebRequest.Create($"https://api.weather.yandex.ru/v2/forecast?lat={coordinates[1]}&lon={coordinates[0]}");
        request.Headers.Add("X-Yandex-API-Key", "2a891cd9-4d14-41db-a034-5f2c18fe6443");
        response = request.GetResponse();
        stream = response.GetResponseStream();
        reader = new StreamReader(stream);
        jsonString = reader.ReadToEnd();
        response.Close();
        var jsonWeather = JsonObject.Parse(jsonString);
        Console.WriteLine($"Температура ночью: {jsonWeather["forecasts"][0]["parts"]["night"]["temp_avg"]}");
        Console.WriteLine($"Температура утром: {jsonWeather["forecasts"][0]["parts"]["morning"]["temp_avg"]}");
        Console.WriteLine($"Температура днем: {jsonWeather["forecasts"][0]["parts"]["day"]["temp_avg"]}");
        Console.WriteLine($"Температура вечером: {jsonWeather["forecasts"][0]["parts"]["evening"]["temp_avg"]}");
        
            
            
    }    
}