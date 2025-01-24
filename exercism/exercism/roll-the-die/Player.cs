using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercism.roll_the_die
{
    internal class Player
    {
        public int RollDie() => new Random().Next(1, 18);
        public double GenerateSpellStrength() => new Random().NextDouble()*100;
    }
}
