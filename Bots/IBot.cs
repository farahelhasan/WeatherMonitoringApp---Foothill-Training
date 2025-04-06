using WeatherMonitoringApp.Models;

namespace WeatherMonitoringApp.Bots
{
    interface IBot
    {
        string BotName { get; }
        bool IsEnabled { get; }
        void Notify(WeatherData data);
    }
}
