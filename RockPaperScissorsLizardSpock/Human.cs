using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Human : Player
    {
        // member variables (HAS A)

        
        // constructor
        public Human(string name)
        {
            this.name = name;
            GetPlayerName();
            return;
        }

        // member methods 
        public string GetPlayerName()
        {
            Console.WriteLine("Welcome " + name +". Please enter your name.");
            name = Console.ReadLine();
            return name;
        }
    }
}
