using System.Net;
using System.Text.Json.Nodes;

Console.WriteLine("Введите город:");
string town = "Москва"; //Console.ReadLine();


HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"https://geocode-maps.yandex.ru/1.x/?apikey=db396852-b7d4-476f-a1f9-4055bba4be43&geocode={town}&format=json");
HttpWebResponse response = (HttpWebResponse)request.GetResponse();
Stream stream = response.GetResponseStream();
StreamReader reader = new StreamReader(stream);
string jsonString = reader.ReadToEnd();
response.Close();
var jsonCoordinates = JsonObject.Parse(jsonString);
string[] coordinates = jsonCoordinates["response"]["GeoObjectCollection"]["featureMember"][0]["GeoObject"]["Point"]["pos"]
    .ToString().Split(' ');
Console.WriteLine(coordinates[1]);
Console.WriteLine(coordinates[0]);


request = (HttpWebRequest)WebRequest.Create($"https://api.weather.yandex.ru/v2/forecast?lat={coordinates[1]}&lon={coordinates[0]}");
request.Headers.Add("X-Yandex-API-Key", "2a891cd9-4d14-41db-a034-5f2c18fe6443");
response = (HttpWebResponse)request.GetResponse();
stream = response.GetResponseStream();
reader = new StreamReader(stream);
jsonString = reader.ReadToEnd();
response.Close();
var jsonWeather = JsonObject.Parse(jsonString);
Console.WriteLine(jsonWeather);
