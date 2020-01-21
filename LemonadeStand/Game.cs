﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Game
    {
        Day day;
        Store store;
        private Player player;
        private List<Day> days;
        private int currentDay;

        public Game()
        {
            days = new List<Day>() {new Day() };
            day = new Day();
            player = new Player();
            store = new Store(player);

            
        }

        public void forecastForNextDay()
        {
            day.weather.PredictedForecast();
        }

        public void dayCounter()
        {
            days.Add(new Day());
            currentDay = days.Count;
        }

        public void dayAndWeather()
        {
            Console.WriteLine("Weather for today is: " + day.weather.condition + " and " + day.weather.temperature + ".");
        }

        public void customersBuyLemonade()
        {
            for(int i = 0; i < day.customers.Count; i++)
            {
                if (store.countPitchersMade > 0 && player.pitcher.cupsLeftInPitcher > 0)
                {
                    player.wallet.Money += .25;
                    player.pitcher.cupsLeftInPitcher--;
                    if(player.pitcher.cupsLeftInPitcher == 0)
                    {
                        store.countPitchersMade--;
                    }
                    Console.WriteLine("You have " + UserInterface.PitchersToBeMade + "Pitcher(s) and " + player.pitcher.cupsLeftInPitcher + " cups left in Pitcher.");
                    
                }
            }
        }

        //public void useStore()
        //{
        //    store.BuyLemons();
        //    store.BuySugarCubes();
        //    store.BuyIceCubes();
        //    store.BuyCups();

        //}

        public void playGame()
        {
            
            UserInterface.Greeting();
            UserInterface.SetPlayerName();
            while (currentDay <= 7)
            {
                day.weather.SetWeatherCondition();
                dayAndWeather();
                day.spawnCustomers();
                store.StoreMenu();
                store.MakePitcher();
                customersBuyLemonade();
                //Console.WriteLine(currentDay);
                forecastForNextDay();
                UserInterface.StartNextDay();
                Console.Clear();
                currentDay++;
            }
            store.ShowProfit();

        }
    }
}
