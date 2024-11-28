using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercism.annalyns_infiltration
{
    public class QuestLogic
    {
        public static bool CanFastAttack(bool knightIsAwake) => !knightIsAwake;

        public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake) =>
            (knightIsAwake || archerIsAwake || prisonerIsAwake);
        //{
        //    if (knightIsAwake || archerIsAwake || prisonerIsAwake)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake) =>
            (!archerIsAwake && prisonerIsAwake) ? true : false;
        /*{
            //if (!archerIsAwake && prisonerIsAwake)
            //{
            //    return true;
            //}
            //return false;
            // USANDO O OPERADOR TERNARIO
            return (!archerIsAwake && prisonerIsAwake) ? true : false;
        }*/

        public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
        {
            if (petDogIsPresent && !archerIsAwake)
            {
                return true;
            }
            else if (prisonerIsAwake && !knightIsAwake && !archerIsAwake)
            {
                return true;
            }
            return false;
        }
    }
}
