using WeatherMonitoringApp.Models;

namespace WeatherMonitoringApp.Bots
{
    class RainBot : IBot
    {
        private string _message;

        private double _humidityThreshold;
        public string BotName => "RainBot";
        public bool IsEnabled { get; }

        public RainBot(BotConfiguration config)
        {
            IsEnabled = config.Enabled;
            _humidityThreshold = config.HumidityThreshold;
            _message = config.Message;
        }

        public void Notify(WeatherData data)
        {
            if (!IsEnabled) return;

            if (data.Humidity >= _humidityThreshold)
            {
                Console.WriteLine($"{BotName} activated!");
                Console.WriteLine($"{BotName}: \"{_message}\"");
            }
        }
    }
}
