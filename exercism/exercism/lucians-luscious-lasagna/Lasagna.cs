using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercism.lucians_luscious_lasagna
{
    public class Lasagna
    {
        public int ExpectedMinutesInOven()
        {
            return 40;
        }

        public int RemainingMinutesInOven(int minute)
        {
            return ExpectedMinutesInOven() - minute;
        }

        public int PreparationTimeInMinutes(int value)
        {
            return value * 2;
        }

        public int ElapsedTimeInMinutes(int value, int minute)
        {
            return PreparationTimeInMinutes(value) + minute;
        }
    }
}
