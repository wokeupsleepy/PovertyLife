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
            Console.WriteLine(arnold.CharacterSummary());

            GameEffect firstEffect = new GameEffectStat(arnold, 1, 5);
            Console.WriteLine(arnold.CharacterSummary());
            GameEffect secondEffect = new GameEffectStat(arnold, 2, 6);
            Console.WriteLine(arnold.CharacterSummary());
            GameEffect thirdEffect = new GameEffectStat(arnold, 3, 7);
            Console.WriteLine(arnold.CharacterSummary());
            GameEffect fourthEffect = new GameEffectStat(arnold, 1, -2);
            Console.WriteLine(arnold.CharacterSummary());

            Character arnoldWife = new Character("Maria", "Shriver", 43);
            Console.WriteLine(arnoldWife.CharacterSummary());
            Character arnoldSon = new Character("John", "Marston", 43);
            Console.WriteLine(arnoldSon.CharacterSummary());

            try
            {
                arnold.familyList.Add(arnoldWife);
                arnold.familyList.Add(arnoldSon);
                string dumbstring = arnold.DisplayCharacterList(arnold.familyList);
                Console.WriteLine(dumbstring);
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
