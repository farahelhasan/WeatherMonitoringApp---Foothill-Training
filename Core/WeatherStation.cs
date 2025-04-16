using WeatherMonitoringApp.Bots;
using WeatherMonitoringApp.Models;

namespace WeatherMonitoringApp.Core
{
    public class WeatherStation
    {
        private List<IBot> _observers = new();

        public void RegisterBot(IBot bot)
        {
            _observers.Add(bot);
        }

        public void ReceiveWeatherNotify(WeatherData data)
        {
            Console.WriteLine($"\n[Weather Update] Location: {data.Location}, Temp: {data.Temperature}, Humidity: {data.Humidity}");

            foreach (var bot in _observers)
            {
                bot.Notify(data);
            }
        }
    }
}
