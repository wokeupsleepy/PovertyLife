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

        static public Dictionary<string, bool> ProbabilityWeek = new Dictionary<string,bool>();

        public static void InitializeProbabilityWeek() 
        {
            ProbabilityWeek.Add("SUNDAY", false);
            ProbabilityWeek.Add("MONDAY", false);
            ProbabilityWeek.Add("TUESDAY", true);
            ProbabilityWeek.Add("WEDNESDAY", false);
            ProbabilityWeek.Add("THURSDAY", false);
            ProbabilityWeek.Add("FRIDAY", true);
            ProbabilityWeek.Add("SATURDAY", false);
        }

        static public int ReturnRandomInt(int desiredNumberOfReturns)
        {
            //Why desiredNumberOfReturns - 1? It's because you have arrays and arraylists that start with a 0-index
            return rand1.Next(desiredNumberOfReturns - 1);
        }

        static public void WriteInvoluntataryEventDeterminationToConsole()
        {
            bool defaultValue = false;

            foreach (string key in ProbabilityWeek.Keys)
            {
                if (ProbabilityWeek.TryGetValue(key, out defaultValue))
                {
                    Console.Write("Day: {0}, Value: {1} \n", key, defaultValue);
                }
            }
        }

    }
}
