
using System.Text.Json;
using WeatherMonitoringApp.Models;

namespace WeatherMonitoringApp.Parsers
{
    class JsonWeatherParser : IWeatherDataParser
    {
        public WeatherData Parse(string input)
        {
            var jsonDoc = JsonDocument.Parse(input);
            var root = jsonDoc.RootElement;

            var location = root.GetProperty("Location").GetString();
            var temperature = root.GetProperty("Temperature").GetDouble();
            var humidity = root.GetProperty("Humidity").GetDouble();

            return new WeatherData(location, temperature, humidity);
        }
    }
}
