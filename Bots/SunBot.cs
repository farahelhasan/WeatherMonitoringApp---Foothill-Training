using WeatherMonitoringApp.Models;

namespace WeatherMonitoringApp.Bots
{
    class SunBot : IBot
    {
        private string _message;

        private double _temperatureThreshold;
        public string BotName => "SunBot";
        public bool IsEnabled { get; }
        public SunBot(BotConfiguration config)
        {
            IsEnabled = config.Enabled;
            _temperatureThreshold = config.TemperatureThreshold;
            _message = config.Message;
        }
        public void Notify(WeatherData data)
        {
            if (!IsEnabled) return;

            if (data.Temperature >= _temperatureThreshold)
            {
                Console.WriteLine($"{BotName} activated!");
                Console.WriteLine($"{BotName}: \"{_message}\"");
            }
        }
       
    }
}
