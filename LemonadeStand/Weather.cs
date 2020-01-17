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
        public List<string> Forecast;

        public Weather()
        {
            weatherConditions = new List<string>() { "Sunny", "Cloudy", "Foggy", "Windy", "Rainy" };

        }

        public void ChooseCondition()
        {
            Random PickCondition = new Random();
            condition = weatherConditions[PickCondition.Next(1,5)];
            Console.WriteLine(condition);
        }

        public int GetTempurature(Random Rnd)
        {
            temperature = Rnd.Next(60, 90);
            return temperature;
        }
     /* public string PredictedForecast()
        {
            Forecast = new List<string>() { };
        }*/
            
    }
}
