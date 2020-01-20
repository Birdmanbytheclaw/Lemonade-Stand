using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Game
    {
        private Player player = new Player();
        private List<Day> days;
        private int currentDay;

        public Game()
        {
            days = new List<Day>() {new Day() };
            
        }

        public int daysToBePlayed()
        {

            return 1;
        }

        public void dayAndWeather()
        {

        }

        public void customersInGame()
        {

        }

        public void useStore()
        {
            

        }

        public void playGame()
        {
            UserInterface.Greeting();
            UserInterface.SetPlayerName();

        }
    }
}
