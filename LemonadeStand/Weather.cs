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
        public string forecast;

        public Weather()
        {
            weatherConditions = new List<string>() { "Sunny", "Cloudy", "Foggy", "Windy", "Rainy" };
            Forecast = new List<string>() {"Hot", "Cold", "Warm", "Cool" };
        }

        public void ChooseCondition()
        {
            Random PickCondition = new Random();
            condition = weatherConditions[PickCondition.Next(1,5)];
            Console.WriteLine("and " + condition);
        }

        public int GetTempurature()
        {
            Random Temperature = new Random();
            temperature = Temperature.Next(60, 90);
            return temperature;
        }

        public void ChooseForecast()
        {
            Random PickForecast = new Random();
            forecast = Forecast[PickForecast.Next(1, 4)];
            Console.WriteLine(forecast);
        }
        public void PredictedForecast()
        {
            Console.WriteLine("It will be" + forecast + " and partly" + condition);
        }

    }
}
