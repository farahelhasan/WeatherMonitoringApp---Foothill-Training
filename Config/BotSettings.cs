using WeatherMonitoringApp.Bots;

namespace WeatherMonitoringApp.Config
{
    public class BotSettings
    {
        public BotConfiguration RainBot { get; set; }
        public BotConfiguration SunBot { get; set; }
        public BotConfiguration SnowBot { get; set; }
    }
}
