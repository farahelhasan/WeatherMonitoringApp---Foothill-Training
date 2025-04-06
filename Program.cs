// See https://aka.ms/new-console-template for more information
using WeatherMonitoringApp.Models;
using WeatherMonitoringApp.Parsers;

Console.WriteLine("Hello, World!");
JsonWeatherParser x = new JsonWeatherParser();
string json = @"
            {
                ""Location"": ""New York"",
                ""Temperature"": 22.5,
                ""Humidity"": 60.0
            }";
WeatherData c = x.Parse(json);
Console.WriteLine(c);
