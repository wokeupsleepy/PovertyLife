using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PovertyLife.Traits;

namespace PovertyLife.Character
{
    class GameCharacter
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public int Age {get; set;}
        public int FreeTime { get; set; }

        public MentalHealth CharacterMentalHealth { get; set; }
        public PhysicalHealth CharacterPhysicalHealth { get; set; }
        public Money CharacterMoney { get; set; }

        public CharacterJob Job { get; set; }

        public HashSet<CharacterTrait> TraitList { get; set; }
        public HashSet<PhysicalInventoryItem> PhysicalInventory { get; set; }
        public HashSet<GameCharacter> FriendsList { get; set; }
        public HashSet<GameCharacter> FamilyList { get; set; }

        public GameCharacter(string inputFirstName, string inputLastName, int inputAge)
        {
            FirstName = inputFirstName;
            LastName = inputLastName;
            Age = inputAge;

            FreeTime = 168;

            CharacterMentalHealth = new MentalHealth(0);
            CharacterPhysicalHealth = new PhysicalHealth(0);
            CharacterMoney = new Money(0);

            TraitList = new HashSet<CharacterTrait>();
            PhysicalInventory = new HashSet<PhysicalInventoryItem>();
            FriendsList = new HashSet<GameCharacter>();
            FamilyList = new HashSet<GameCharacter>();
        }

        public string CharacterSummary()
        {
            string summary = FirstName + " " + LastName + " is " + Age + " years old." + " |"
                + "Physical Health: " + CharacterPhysicalHealth.CurrentValue + " |"
                + "Mental Health: " + CharacterMentalHealth.CurrentValue + " |"
                + "Money: " + CharacterMoney.CurrentValue;

            return summary;
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }

        public string DisplayCharacterList(HashSet<GameCharacter> inputList)
        {
            return string.Join(", ", inputList);
        }

        public int CalculateRemainingFreeTime(int freeTimeEffect)
        {
            return FreeTime + freeTimeEffect;
        }

    }
}
