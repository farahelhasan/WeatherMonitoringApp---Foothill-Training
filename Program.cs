using WeatherMonitoringApp.Bots;
using WeatherMonitoringApp.Config;

namespace WeatherMonitoringApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
                var config = ConfigLoader.Load("config.json");

                // Create bots
                List<IBot> bots = new()
                {
                    new RainBot(config.RainBot),
                    new SunBot(config.SunBot),
                    new SnowBot(config.SnowBot)
                };
        
        }
        }

    }

