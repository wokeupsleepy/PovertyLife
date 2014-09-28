using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PovertyLife.Traits;
using PovertyLife.Events;
using PovertyLife.Character;

namespace PovertyLife
{
    class Program
    {
        static void Main(string[] args)
        {
            GameCharacter arnold = new GameCharacter("Arnold", "Strong", 45);
            Console.WriteLine(arnold.CharacterSummary());

            GameEffect firstEffect = new GameEffectStat(arnold, 1, 5);
            Console.WriteLine(arnold.CharacterSummary());
            GameEffect secondEffect = new GameEffectStat(arnold, 2, 6);
            Console.WriteLine(arnold.CharacterSummary());
            GameEffect thirdEffect = new GameEffectStat(arnold, 3, 7);
            Console.WriteLine(arnold.CharacterSummary());
            GameEffect fourthEffect = new GameEffectStat(arnold, 1, -2);
            Console.WriteLine(arnold.CharacterSummary());

            GameCharacter arnoldWife = new GameCharacter("Maria", "Shriver", 43);
            Console.WriteLine(arnoldWife.CharacterSummary());
            GameCharacter arnoldSon = new GameCharacter("John", "Marston", 10);
            Console.WriteLine(arnoldSon.CharacterSummary());

            try
            {
                arnold.FamilyList.Add(arnoldWife);
                arnold.FamilyList.Add(arnoldSon);
                string dumbstring = arnold.DisplayCharacterList(arnold.FamilyList);
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
