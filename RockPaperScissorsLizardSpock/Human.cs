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
        public Human()
        {
            this.name = GetPlayerName();

        }

        // member methods 
        public string GetPlayerName()
        {
            Console.WriteLine("Welcome")
            return ("Name");
        }
    }
}
