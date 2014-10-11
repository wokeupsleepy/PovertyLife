using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PovertyLife.TurnAndTimeDetermination
{
    static class InvoluntaryEventDetermination
    {
        static public Dictionary<string, bool> ProbabilityWeek = new Dictionary<string, bool>();

        static double dayProbability = 0.33;
        static double hourProbability = 0.04;
        //remember, a turn = 15 min, so 4 turns in an hour
        static double turnProbability = 0.25;

        public static void InitializeProbabilityWeek()
        {
            ProbabilityWeek.Add("SUNDAY", InitializeDayProbability() <= dayProbability);
            ProbabilityWeek.Add("MONDAY", InitializeDayProbability() <= dayProbability);
            ProbabilityWeek.Add("TUESDAY", InitializeDayProbability() <= dayProbability);
            ProbabilityWeek.Add("WEDNESDAY", InitializeDayProbability() <= dayProbability);
            ProbabilityWeek.Add("THURSDAY", InitializeDayProbability() <= dayProbability);
            ProbabilityWeek.Add("FRIDAY", InitializeDayProbability() <= dayProbability);
            ProbabilityWeek.Add("SATURDAY", InitializeDayProbability() <= dayProbability);
        }

        static private double InitializeDayProbability()
        {
            RNGCryptoServiceProvider randomGenerator = new RNGCryptoServiceProvider();
                double generatedProbability;

                byte[] byteContainer = new byte[1];
                randomGenerator.GetBytes(byteContainer);
                generatedProbability = (double)(byteContainer[0]) / (double)(Byte.MaxValue);
            //uncomment the line below if you want to see the generatedProbabilities to check
                //Console.WriteLine(generatedProbability);
                return generatedProbability;
        }

        static public void WriteInvoluntataryEventDeterminationToConsole()
        {
            bool defaultValue = false;

            Console.WriteLine("----Begin Probability Summary----");

            foreach (string key in ProbabilityWeek.Keys)
            {
                if (ProbabilityWeek.TryGetValue(key, out defaultValue))
                {
                    Console.Write("Day: {0}, Value: {1} \n", key, defaultValue);
                }
            }

            Console.WriteLine("----End Probability Summary----");

        }

    }
}
