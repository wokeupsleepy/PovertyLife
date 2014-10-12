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
        static public Dictionary<int, bool> ProbabilityHour = new Dictionary<int, bool>();
        static public Dictionary<int, bool> ProbabilityTurn = new Dictionary<int, bool>();

        static double dayProbability = 0.25;
        static double hourProbability = 0.03;
        //remember, a turn = 15 min, so 4 turns in an hour
        static double turnProbability = 0.15;
        
        public static void InitializeProbabilityWeek()
        {
            ProbabilityWeek.Add("SUNDAY", GenerateD100Probability() <= dayProbability);
            ProbabilityWeek.Add("MONDAY", GenerateD100Probability() <= dayProbability);
            ProbabilityWeek.Add("TUESDAY", GenerateD100Probability() <= dayProbability);
            ProbabilityWeek.Add("WEDNESDAY", GenerateD100Probability() <= dayProbability);
            ProbabilityWeek.Add("THURSDAY", GenerateD100Probability() <= dayProbability);
            ProbabilityWeek.Add("FRIDAY", GenerateD100Probability() <= dayProbability);
            ProbabilityWeek.Add("SATURDAY", GenerateD100Probability() <= dayProbability);
        }

        public static void InitializeProbabilityHour()
        {
            int i = 0;
            while(i < 24) {
                ProbabilityHour.Add(i, GenerateD100Probability() <= hourProbability);
                i++;
            }
        }

        public static void InitializeProbabilityTurn()
        {
            int i = 0;
            while (i < 4)
            {
                ProbabilityTurn.Add(i, GenerateD100Probability() <= turnProbability);
                i++;
            }
        }

        static private double GenerateD100Probability()
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

            foreach (int key in ProbabilityHour.Keys)
            {
                if (ProbabilityHour.TryGetValue(key, out defaultValue))
                {
                    Console.Write("Hour: {0}, Value: {1} \n", key, defaultValue);
                }
            }

            foreach (int key in ProbabilityTurn.Keys)
            {
                if (ProbabilityTurn.TryGetValue(key, out defaultValue))
                {
                    Console.Write("Turn: {0}, Value: {1} \n", key, defaultValue);
                }
            }

            Console.WriteLine("----End Probability Summary----");

        }

    }
}
