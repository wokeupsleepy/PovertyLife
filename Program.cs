using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PovertyLife.Traits;
using PovertyLife.Events;
using PovertyLife.Character;
using PovertyLife.DAL;
using PovertyLife.TurnAndTimeDetermination;

namespace PovertyLife
{
    class Program
    {

        static void Main(string[] args)
        {
            GameCharacter arnold = new GameCharacter("Arnold", "Strong", 45);
            Console.WriteLine(arnold.CharacterSummary());

            //Tests to perform to check GameEffects
            Console.WriteLine("GameEffect tests");
            GameEffect firstEffect = new GameEffectStat(arnold, 1, 5);
            Console.WriteLine(arnold.CharacterSummary());
            GameEffect secondEffect = new GameEffectStat(arnold, 2, 6);
            Console.WriteLine(arnold.CharacterSummary());
            GameEffect thirdEffect = new GameEffectStat(arnold, 3, 7);
            Console.WriteLine(arnold.CharacterSummary());
            GameEffect fourthEffect = new GameEffectStat(arnold, 1, -2);
            Console.WriteLine(arnold.CharacterSummary());

            GameCharacter arnoldWife = new GameCharacter("Maria", "Shriver", 43);
            GameCharacter arnoldSon = new GameCharacter("John", "Marston", 10);

            //DateTime thisTime = new DateTime(1990, 2, 13, 2, 1, 11);
            //GameCalendar calendar = new GameCalendar(thisTime);
            //calendar.ImportantDate = new DateTime(1991, 2, 13);
            //calendar.CurrentTime = calendar.AddYears(calendar.CurrentTime, 1);

            //Console.WriteLine(thisTime.ToString());
            //Console.WriteLine(calendar.GetYear(thisTime));

            //Console.WriteLine(calendar.ImportantDate.ToString());
            //Console.WriteLine(calendar.GetYear(calendar.ImportantDate));

            //Console.WriteLine(calendar.CheckDateTimesSameDate(calendar.ImportantDate, calendar.CurrentTime));

            Console.WriteLine("InvoluntaryEventDetermination tests");
            InvoluntaryEventDetermination.InitializeProbabilityWeek();
            InvoluntaryEventDetermination.InitializeProbabilityHour();
            InvoluntaryEventDetermination.WriteInvoluntataryEventDeterminationToConsole();

            try
            {
                Console.WriteLine("Character Family and Friends tests");
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
