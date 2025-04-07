using WeatherMonitoringApp.Bots;
using WeatherMonitoringApp.Config;
using WeatherMonitoringApp.Core;
using WeatherMonitoringApp.Parsers;

namespace WeatherMonitoringApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = ConfigLoader.Load("config.json");

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

            List<IWeatherDataParser> parsers = new()
            {
                new JsonWeatherParser(),
                new XmlWeatherParser()
            };

            while (true)
            {
                Console.WriteLine("\nEnter weather data (or 'exit' to quit):");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit") break;

                // Chose format (Use a Strategy pattern to chose  correct parser depending on the format.)
                IWeatherDataParser parser = parsers.FirstOrDefault(p => p.CanParse(input));

                if (parser == null)
                {
                    Console.WriteLine("Unsupported format. Please enter valid JSON or XML.");
                    continue;
                }

                try
                {
                    var data = parser.Parse(input);
                    Console.WriteLine(data);
                    station.ReceiveWeatherNotify(data);
                }
                catch
                {
                    Console.WriteLine("Failed to parse data. Please check the format.");
                }

            }
        }
    }
}

    

