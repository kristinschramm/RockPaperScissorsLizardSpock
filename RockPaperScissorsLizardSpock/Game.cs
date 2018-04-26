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
        List<string> choices = new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        List<Player> players = new List<Player> { };

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
            AddPlayerToList();
            Round();
            CheckScore();
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
            playerCount = GetUserInput();
            CheckPlayerCount();
            return playerCount;
        }
        public void Round()
        {

            for (int i = 0; i < players.Count(); i++)
            {
                Console.Clear();
                Console.WriteLine("Ready " + players[i].name + "It's your turn!");
                DisplayChoicesMenu();
                if (players[i].name == "Sparky")
                {
                    //write functions for random 
                }
                else
                {
                    players[i].choice = GetUserInput();

                }
                CheckChoiceInput(players[i].choice);
                


            }
            ComparePlayerChoice(player1.choice);

        }
        public void Player1Wins()
        {
            Console.WriteLine(player1.name + " wins!");
            player1.score = player1.score++;
        }
        public void Player2Wins()
        {
            Console.WriteLine(player2.name + " wins!");
            player2.score = player2.score++;
        }
        public void CheckScore()
        {

        }
        public void DisplayChoicesMenu()
        {
            Console.WriteLine("Let's Play!");
            Console.WriteLine("1. Rock");
            Console.WriteLine("2. Paper");
            Console.WriteLine("3. Scissors");
            Console.WriteLine("4. Lizard");
            Console.WriteLine("5. Spock");
        }
        public void AddPlayerToList()
        {
            players.Add(player1);
            players.Add(player2);
        }
        public void CheckChoiceInput(string choice)
        {
            switch (choice)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "rock":
                case "Rock":
                    choice = "1";
                    break;
                case "paper":
                case "Paper":
                    choice = "2";
                    break;
                case "scissors":
                case "Scissors":
                    choice = "3";
                    break;
                case "lizard":
                case "Lizard":
                    choice = "4";
                    break;
                case "spock":
                case "Spock":
                    choice = "5";
                    break;
                default:
                    Console.WriteLine("Oops! Invalid entry. Try again.");
                    DisplayChoicesMenu();
                    break;
            }
        }
        public void ComparePlayerChoice(string choice)
        {
            if (player1.choice == player2.choice)
            {
                Console.WriteLine("It's a Tie!");
                return;
            }
            else if (player1.choice == "1" || player2.choice == "1")
            {
                RockCheck();
                return;
            }
            else if (player1.choice == "2" || player2.choice == "2")
            {
                PaperCheck();
                return;
            }
            else if (player1.choice == "3" || player2.choice == "3")
            {
                ScissorsCheck();
                return;
            }

        }
        public void RockCheck()
        {
            if (player1.choice == "2" || player2.choice == "2")
            {
                Console.WriteLine("Paper covers rock!");
                    if (player1.choice == "2")
                    {
                    Player1Wins();
                    }
                    else {
                    Player2Wins();
                    }
                
            }
            else if (player1.choice=="3" || player2.choice == "3")
            {
                Console.WriteLine("Rocks beats scissor!");
                if (player1.choice == "1")
                {
                    Player1Wins();
                }
                else
                {
                    Player2Wins();
                }
            }
            else if (player1.choice == "4" || player2.choice == "4")
            {
                Console.WriteLine("Rock crushes lizard!");
                if (player1.choice == "1")
                {
                    Player1Wins();
                }
                else
                {
                    Player2Wins();
                }
            }
            else if (player1.choice == "5" || player2.choice == "5")
            {
                Console.WriteLine("Spock vaporizes rock!");
                if (player1.choice == "5")
                {
                    Player1Wins();
                }
                else
                {
                    Player2Wins();
                }
            }
            
        }
        public void PaperCheck()
        {
            if (player1.choice == "3" || player2.choice == "3")
            {
                Console.WriteLine("Scissors cuts Paper!");
                if (player1.choice == "3")
                {
                    Player1Wins();
                }
                else
                {
                    Player2Wins();
                }
            }
            else if (player1.choice == "4" || player2.choice == "4")
            {
                Console.WriteLine("Lizard eats paper!");
                if (player1.choice == "4")
                {
                    Player1Wins();
                }
                else
                {
                    Player2Wins();
                }
            }
            else if (player1.choice == "5" || player2.choice == "5")
            {
                Console.WriteLine("Paper disproves Spock!");
                if (player1.choice == "2")
                {
                    Player1Wins();
                }
                else
                {
                    Player2Wins();
                }
            }
        }
        public void ScissorsCheck()
            {
                if (player1.choice == "4" || player2.choice == "4")
                {
                    Console.WriteLine("Scissors decapitates Lizard!");
                    if (player1.choice == "3")
                    {
                        Player1Wins();
                    }
                    else
                    {
                        Player2Wins();
                    }
                }
                else if (player1.choice == "5" || player2.choice == "5")
                {
                    Console.WriteLine("Spock smashes Scissors!");
                    if (player1.choice == "5")
                    {
                        Player1Wins();
                    }
                    else
                    {
                        Player2Wins();
                    }
                }
            }
        public void LizardCheck()
        {
            Console.WriteLine("Lizard poisons Spock!");
                if (player1.choice == "4")
                {
                    Player1Wins();
                }
                else
                {
                    Player2Wins();
                }
            }
        }
}

