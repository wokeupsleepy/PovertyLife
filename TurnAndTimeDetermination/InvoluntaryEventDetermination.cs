using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PovertyLife.TurnAndTimeDetermination
{
    /*
     * Every character should have one InvoluntaryEventDetermination object.
     * This will be used to figure out if an InvoluntaryEvent should interrupt the Character's daily actions.
     * This class is only used to figure out IF (READ THIS: IF) an InvoluntaryEvent should be triggered.
     * Another class (name TBD) will be used to figure out WHICH (READ THIS: WHICH) InvoluntaryEvent will be triggered.
     */

    class InvoluntaryEventDetermination
    {
        public Dictionary<string, bool> ProbabilityWeek = new Dictionary<string, bool>();
        public Dictionary<int, bool> ProbabilityHour = new Dictionary<int, bool>();
        public Dictionary<int, bool> ProbabilityTurn = new Dictionary<int, bool>();

        double dayProbability = 0.25;
        double hourProbability = 0.03;
        //remember, a turn = 15 min, so 4 turns in an hour
        double turnProbability = 0.15;
        
        public void InitializeProbabilityWeek()
        {
            ProbabilityWeek.Add("SUNDAY", GenerateD100Probability() <= dayProbability);
            ProbabilityWeek.Add("MONDAY", GenerateD100Probability() <= dayProbability);
            ProbabilityWeek.Add("TUESDAY", GenerateD100Probability() <= dayProbability);
            ProbabilityWeek.Add("WEDNESDAY", GenerateD100Probability() <= dayProbability);
            ProbabilityWeek.Add("THURSDAY", GenerateD100Probability() <= dayProbability);
            ProbabilityWeek.Add("FRIDAY", GenerateD100Probability() <= dayProbability);
            ProbabilityWeek.Add("SATURDAY", GenerateD100Probability() <= dayProbability);
        }

        public void InitializeProbabilityHour()
        {
            int i = 0;
            while(i < 24) {
                ProbabilityHour.Add(i, GenerateD100Probability() <= hourProbability);
                i++;
            }
        }

        public void InitializeProbabilityTurn()
        {
            int i = 0;
            while (i < 4)
            {
                ProbabilityTurn.Add(i, GenerateD100Probability() <= turnProbability);
                i++;
            }
        }

        private double GenerateD100Probability()
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

        public void WriteInvoluntataryEventDeterminationToConsole()
        {
            bool defaultValue = false;

            Console.WriteLine("InvoluntaryEventDetermination tests");
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
