using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Dice
    {
        public int RollValue { get; set; }
        public int Roll()
        {
            Random rand = new Random();
            int r = rand.Next(1, 20);
            return r;
        }
    }
}
