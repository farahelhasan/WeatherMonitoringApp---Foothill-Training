
using WeatherMonitoringApp.Models;

namespace WeatherMonitoringApp.Parsers
{
    interface IWeatherDataParser
    {
        WeatherData Parse(string input);
    }
}
