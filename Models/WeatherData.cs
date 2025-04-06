using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringApp.Models
{
    class WeatherData
    {
        public string Location { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }

        public WeatherData(string location, double temperature, double humidity)
        {
            Location = location;
            Temperature = temperature;
            Humidity = humidity;
        }

        public override string ToString()
        {
            return $"Location: {Location}, Temperature: {Temperature}, Humidity: {Humidity}";
        }
    }
}
