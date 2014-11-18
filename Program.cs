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
using System.Web.Script.Serialization;

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
            GameEffectStat firstEffect = new GameEffectStat(arnold, GameEffectStat.StatChangeType.MENTALHEALTH, 5);
            firstEffect.ExecuteEffect();
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

            arnold.InvoluntaryEventDeterminer = new InvoluntaryEventDetermination();

            arnold.InvoluntaryEventDeterminer.InitializeProbabilityWeek();
            arnold.InvoluntaryEventDeterminer.InitializeProbabilityHour();
            arnold.InvoluntaryEventDeterminer.InitializeProbabilityTurn();
            arnold.InvoluntaryEventDeterminer.ResetProbabilityWeek();

            try
            {
                Console.WriteLine("Character Family and Friends tests");
                arnold.FamilyList.Add(arnoldWife);
                arnold.FamilyList.Add(arnoldSon);
                string dumbstring = arnold.DisplayCharacterList(arnold.FamilyList);
                Console.WriteLine(dumbstring);


                //TODO: Need to create serializable objects here, only have properties, no methods, create a separate class to perform operations
                //string jsonArnold = new JavaScriptSerializer().Serialize(arnold);
                //string jsonArnoldSon = new JavaScriptSerializer().Serialize(arnoldSon);
                //string jsonArnoldWife = new JavaScriptSerializer().Serialize(arnoldWife);

                ////var exe = 123;

                //Console.WriteLine(jsonArnold);
                //Console.WriteLine(jsonArnoldSon);
                //Console.WriteLine(jsonArnoldWife);

                //TODO: Need to do this so that a data can be passed in JSON format
                Console.WriteLine("Javascript Serializer JSON test");

                TestEntity tester = new TestEntity
                {
                    Id = 0,
                    Name = "Thisser"
                };

                string testEntitySerialized = new JavaScriptSerializer().Serialize(tester);

                Console.WriteLine(testEntitySerialized);


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
