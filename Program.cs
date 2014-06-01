using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PovertyLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Character arnold = new Character("Arnold", "Strong", 45);
            Console.WriteLine(arnold.characterSummary());

            GameEffect firstEffect = new GameEffectStat(arnold, 1, 5);
            Console.WriteLine(arnold.characterSummary());
            GameEffect secondEffect = new GameEffectStat(arnold, 2, 6);
            Console.WriteLine(arnold.characterSummary());
            GameEffect thirdEffect = new GameEffectStat(arnold, 3, 7);
            Console.WriteLine(arnold.characterSummary());
            GameEffect fourthEffect = new GameEffectStat(arnold, 1, -2);
            Console.WriteLine(arnold.characterSummary());

            Character arnoldWife = new Character("Maria", "Shriver", 43);
            Console.WriteLine(arnoldWife.characterSummary());

            try
            {
                arnold.dumbHashSet.Add(3);
                arnold.familyList.Add(arnoldWife);
                Console.WriteLine(arnold.familyList.ToString());
                //create method to print out contents of a HashSet, probably will need to iterate every element

            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("FUCKING NULL REFERENCE");
                Console.WriteLine(e.StackTrace);
            }
            catch (Exception effort)
            {
                Console.WriteLine(effort.StackTrace);
            }

            Console.ReadLine();
        }
    }
}
