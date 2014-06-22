using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PovertyLife
{
    class Character
    {
        public string firstName {get; set;}
        public string lastName {get; set;}
        public int age {get; set;}
        public int freeTime { get; set; }

        public MentalHealth characterMentalHealth { get; set; }
        public PhysicalHealth characterPhysicalHealth { get; set; }
        public Money characterMoney { get; set; }

        public CharacterTrait job { get; set; }

        public HashSet<CharacterTrait> traitList { get; set; }
        public HashSet<PhysicalInventoryItem> physicalInventory { get; set; }
        public HashSet<Character> friendsList { get; set; }
        public HashSet<Character> familyList { get; set; }

        public Character()
        {
            firstName = "";
            lastName = "";
            age = 0;
            freeTime = 168; //7 days * 24 hrs/day = 168 hours
            job = null;
            characterMentalHealth = new MentalHealth(0);
            characterPhysicalHealth = new PhysicalHealth(0);
            characterMoney = new Money(0);

            traitList = new HashSet<CharacterTrait>();
            physicalInventory = new HashSet<PhysicalInventoryItem>();
            friendsList = new HashSet<Character>();
            familyList = new HashSet<Character>();
        }

        public Character(string inputFirstName, string inputLastName, int inputAge)
        {
            firstName = inputFirstName;
            lastName = inputLastName;
            age = inputAge;
            characterMentalHealth = new MentalHealth(0);
            characterPhysicalHealth = new PhysicalHealth(0);
            characterMoney = new Money(0);

            traitList = new HashSet<CharacterTrait>();
            physicalInventory = new HashSet<PhysicalInventoryItem>();
            friendsList = new HashSet<Character>();
            familyList = new HashSet<Character>();
        }

        public string CharacterSummary()
        {
            string summary = firstName + " " + lastName + " is " + age + " years old." + " |"
                + "Physical Health: " + characterPhysicalHealth.currentValue + " |"
                + "Mental Health: " + characterMentalHealth.currentValue + " |"
                + "Money: " + characterMoney.currentValue;

            return summary;
        }

        public override string ToString()
        {
            return this.firstName + " " + this.lastName;
        }

        public string DisplayCharacterList(HashSet<Character> inputList)
        {
            string hashToString = string.Join(", ", inputList);
            return hashToString;
        }

        public int CalculateRemainingFreeTime(int freeTimeEffect)
        {
            freeTime = freeTime + freeTimeEffect;
            return freeTime;
        }

    }
}
