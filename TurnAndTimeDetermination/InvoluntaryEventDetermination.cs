using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PovertyLife.TurnAndTimeDetermination
{
    static class InvoluntaryEventDetermination
    {
        static private Random rand1 = new Random();

        static public bool[] arrayWeek = new bool[7];

        static public void SetArrayWeek()
        {
            foreach (bool day in arrayWeek)
            {
                //need to figure out how to set if day is going to have random event determination or not

            }
        }

        static public int ReturnRandomInt(int desiredNumberOfReturns)
        {
            //Why desiredNumberOfReturns - 1? It's because you have arrays and arraylists that start with a 0-index
            return rand1.Next(desiredNumberOfReturns - 1);
        }

        static public void WriteInvoluntataryEventDeterminationToConsole()
        {
            foreach (bool element in InvoluntaryEventDetermination.arrayWeek)
            {
                Console.WriteLine(element);
            }
        }

    }
}
