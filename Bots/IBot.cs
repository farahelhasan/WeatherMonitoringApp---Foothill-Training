using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
