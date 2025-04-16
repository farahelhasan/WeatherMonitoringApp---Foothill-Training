
using WeatherMonitoringApp.Models;

namespace WeatherMonitoringApp.Parsers
{
    public interface IWeatherDataParser
    {
        WeatherData Parse(string input);
        bool CanParse(string input);
    }
}
