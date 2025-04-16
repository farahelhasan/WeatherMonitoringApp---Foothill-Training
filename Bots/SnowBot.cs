using WeatherMonitoringApp.Models;

namespace WeatherMonitoringApp.Bots
{
    public class SnowBot : IBot
    {
        private readonly string _message;

        private readonly double _temperatureThreshold;
        public string BotName => "SnowBot";
        public bool IsEnabled { get; }
        public SnowBot(BotConfiguration config)
        {
            IsEnabled = config.Enabled;
            _temperatureThreshold = config.TemperatureThreshold;
            _message = config.Message;
        }

        public void Notify(WeatherData data)
        {
            if (!IsEnabled) return;

            if (data.Temperature <= _temperatureThreshold)
            {
                Console.WriteLine($"{BotName} activated!");
                Console.WriteLine($"{BotName}: \"{_message}\"");
            }
        }
    }
}
