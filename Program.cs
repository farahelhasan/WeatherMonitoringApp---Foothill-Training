using WeatherMonitoringApp.Bots;
using WeatherMonitoringApp.Config;
using WeatherMonitoringApp.Core;

namespace WeatherMonitoringApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
                var config = ConfigLoader.Load("config.json");

                // Create bots (load config form config.json)
                List<IBot> bots = new()
                {
                    new RainBot(config.RainBot),
                    new SunBot(config.SunBot),
                    new SnowBot(config.SnowBot)
                };

                var station = new WeatherStation();
                foreach (var bot in bots)
                {
                    station.RegisterBot(bot);
                }

        }
    }

    }

