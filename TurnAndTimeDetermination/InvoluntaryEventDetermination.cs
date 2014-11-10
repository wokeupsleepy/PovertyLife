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
     * 
     * At the beginning of a game week, a new ProbabilityWeek is generated for the Character.
     * If an event has a chance to occur on a given day, a ProbabilityWeek is generated to give which days could have an event.
     * At the beginning of a "possible" day, generate a ProbabilityHour to figure out which hours might have an event.
     * Do the same for ProbabilityTurn.
     * 
     * Create a method to determine likelihood of NO events occurring in a given week.
     * The inverse of this would give the likelihood a given week having any events.
     */

    public class InvoluntaryEventDetermination
    {
        public Dictionary<string, bool> ProbabilityWeek = new Dictionary<string, bool>();
        public Dictionary<int, bool> ProbabilityHour = new Dictionary<int, bool>();
        public Dictionary<int, bool> ProbabilityTurn = new Dictionary<int, bool>();

        //below 3 probabilities state the percentage chance an event will occur on a given in-game day, hour, or turn
        public double dayInvoluntaryEventProbability = 0.25;
        public double hourInvoluntaryEventProbability = 0.05;
        //remember, a turn = 15 min, so 4 turns in an hour
        public double turnInvoluntaryEventProbability = 0.15;

        public void InitializeProbabilityWeek()
        {
            ProbabilityWeek.Add("SUNDAY", GenerateD100Probability() <= dayInvoluntaryEventProbability);
            ProbabilityWeek.Add("MONDAY", GenerateD100Probability() <= dayInvoluntaryEventProbability);
            ProbabilityWeek.Add("TUESDAY", GenerateD100Probability() <= dayInvoluntaryEventProbability);
            ProbabilityWeek.Add("WEDNESDAY", GenerateD100Probability() <= dayInvoluntaryEventProbability);
            ProbabilityWeek.Add("THURSDAY", GenerateD100Probability() <= dayInvoluntaryEventProbability);
            ProbabilityWeek.Add("FRIDAY", GenerateD100Probability() <= dayInvoluntaryEventProbability);
            ProbabilityWeek.Add("SATURDAY", GenerateD100Probability() <= dayInvoluntaryEventProbability);
        }

        public void InitializeProbabilityHour()
        {
            int i = 0;
            while(i < 24) {
                ProbabilityHour.Add(i, GenerateD100Probability() <= hourInvoluntaryEventProbability);
                i++;
            }
        }

        public void InitializeProbabilityTurn()
        {
            int i = 0;
            while (i < 4)
            {
                ProbabilityTurn.Add(i, GenerateD100Probability() <= turnInvoluntaryEventProbability);
                i++;
            }
        }

        public void ResetProbabilityWeek()
        {
            ProbabilityWeek = new Dictionary<string, bool>();
        }
    
        public void ResetProbabilityHour()
        {
            ProbabilityHour = new Dictionary<int, bool>();
        }

        public void ResetProbabilityTurn()
        {
            ProbabilityTurn = new Dictionary<int, bool>();
        }

        public double CalculateExpectedValue()
        {
            double ExpectedValueOfEvents = (1 * dayInvoluntaryEventProbability) + (0 * (1 - dayInvoluntaryEventProbability));
            return ExpectedValueOfEvents;
        }

        private double GenerateD100Probability()
        {
            //technically it's a D256 but who's counting? LOLZ
            RNGCryptoServiceProvider randomGenerator = new RNGCryptoServiceProvider();
            double generatedProbability;
            //below 3 lines: Create a single byte array, fill it with a single value (between 0 and 255), divide by the max byte value (255)
            byte[] byteContainer = new byte[1];
            randomGenerator.GetBytes(byteContainer);
            generatedProbability = (double)(byteContainer[0]) / (double)(Byte.MaxValue);
            //explicitly dispose randomGenerator so next probability is "cryptographically" solid
            randomGenerator.Dispose();
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
