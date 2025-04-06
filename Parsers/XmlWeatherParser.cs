using System.Xml;
using WeatherMonitoringApp.Models;

namespace WeatherMonitoringApp.Parsers
{
    class XmlWeatherParser : IWeatherDataParser
    {
        public WeatherData Parse(string input)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(input);

            var location = xmlDoc.SelectSingleNode("//Location")?.InnerText;
            var temperature = double.Parse(xmlDoc.SelectSingleNode("//Temperature")?.InnerText);
            var humidity = double.Parse(xmlDoc.SelectSingleNode("//Humidity")?.InnerText);

            return new WeatherData(location, temperature, humidity);
        }
    }
}
