using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Dice
    {
        // Define dice roll property
        public int RollValue { get; set; }
        
        // Method to roll a dice
        public int Roll()
        {
            // Return a random value from 1-20 to simulate a dice roll
            Random rand = new Random();
            int r = rand.Next(1, 21);
            return r;
        }
    }
}
