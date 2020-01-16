using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Weather
    {
        public string condition;
        public int temperature;
        private List<string> weatherConditions;
        public string predictedForecast;

        public Weather()
        {
            weatherConditions = new List<string>() { "Sunny", "Cloudy", "Foggy", "Windy", "Rainy" };

        }


        public int GetTempurature(Random Rnd)
        {
            int temperature = Rnd.Next(1, 5);

            switch (temperature)
            {
                case 1:
                    this.temperature = 90;
                    break;
                case 2:
                    this.temperature = 80;
                    break;
                case 3:
                    this.temperature = 70;
                    break;
                case 4:
                    this.temperature = 60;
                    break;
                default:
                    Console.WriteLine("Crazy weather, Cannot find report");
                    break;
            }
            return temperature;
        }
            
    }
}
