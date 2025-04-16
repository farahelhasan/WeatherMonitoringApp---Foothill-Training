using System.Text.Json;

namespace WeatherMonitoringApp.Config
{
    public class ConfigLoader
    {
        public static BotSettings Load(string path)
        {
            var json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<BotSettings>(json);
        }
    }
}
