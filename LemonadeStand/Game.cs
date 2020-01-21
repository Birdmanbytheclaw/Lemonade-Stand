using System;
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
                if (day.customers[i].chanceBuy > 70)
                {
                    player.wallet.Money += .25;
                    Console.WriteLine("You have " + UserInterface.PitchersToBeMade + "Pitchers and " + player.pitcher.cupsLeftInPitcher + " cups left in Pitcher.");
                    //if (UserInterface.PitchersToBeMade == 0 && player.pitcher.cupsLeftInPitcher == 0)
                    //{
                    //    break;
                    //}
                    player.pitcher.cupsLeftInPitcher--;
                    if(player.pitcher.cupsLeftInPitcher == 0)
                    {
                        UserInterface.PitchersToBeMade--;
                        player.pitcher.cupsLeftInPitcher = 10;
                        if(UserInterface.PitchersToBeMade == 0)
                        {
                            break;
                        }
                    }
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
                player.inventory.MakePitcher();
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
