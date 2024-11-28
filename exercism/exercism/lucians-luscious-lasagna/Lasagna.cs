using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercism.lucians_luscious_lasagna
{
    public class Lasagna
    {
        // TODO: define the 'ExpectedMinutesInOven()' method
        public int ExpectedMinutesInOven()
        {
            return 40;
        }

        // TODO: define the 'RemainingMinutesInOven()' method
        public int RemainingMinutesInOven(int minute)
        {
            return ExpectedMinutesInOven() - minute;
        }

        // TODO: define the 'PreparationTimeInMinutes()' method
        public int PreparationTimeInMinutes(int value)
        {
            return value * 2;
        }

        // TODO: define the 'ElapsedTimeInMinutes()' method
        public int ElapsedTimeInMinutes(int value, int minute)
        {
            return PreparationTimeInMinutes(value) + minute;
        }
    }
}
