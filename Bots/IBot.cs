using WeatherMonitoringApp.Models;

namespace WeatherMonitoringApp.Bots
{
    public interface IBot
    {
        string BotName { get; }
        bool IsEnabled { get; }
        void Notify(WeatherData data);
    }
}
