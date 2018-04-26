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
        public string playerCount;
        
        // constructor
        public Game()
        {
           BeginGame();
        }

        // member methods 

        public void BeginGame()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock!");
            GetPlayerCount();
            CheckPlayerCount();           

        }

        public string GetUserInput()
        {
            string input = Console.ReadLine();
            return input;
            //validate input
        }

        public void CheckPlayerCount()
        {
            if (playerCount == "1")
            {
                player1 = new Human("Player 1");
                player2 = new Ai();
                Console.WriteLine(player1.name + " vs " + player2.name + " Let's go!");
                return;
            }
            else if (playerCount == "2")
            {
                player1 = new Human("Player 1");
                player2 = new Human("Player 2");
                Console.WriteLine(player1.name + " vs " + player2.name + " Let's go!");
                return;
            }
            else
            {
                Console.WriteLine("That doesn't seem right, please enter 1 or 2.");
                GetPlayerCount();
            }
        }

        public string GetPlayerCount()
        {
            Console.WriteLine("How many players are there? 1 or 2?");
            playerCount=GetUserInput();
            CheckPlayerCount();
            return playerCount;
        }
    }
}
