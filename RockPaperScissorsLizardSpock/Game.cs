using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Game
    {
        // member variables (HAS A)
        Player player1;
        Player player2;
        string playerCount;


        // constructor
        public Game()
        {
            BeginGame();
        }

        // member methods 

        public void BeginGame()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock!");
            Console.WriteLine("How many players are there?");
            GetUserInput(playerCount);
            CheckPlayerCount();           

        }

        public string GetUserInput(string input)
        {
            input= Console.ReadLine();
            return input;
            //validate input
        }

        public void CheckPlayerCount()
        {
            if (playerCount == "1")
            {

            }
        }
    }
}
