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

        CharacterTrait job = new CharacterTrait();

        private ArrayList traitList = new ArrayList();
        private ArrayList friendsList = new ArrayList();
        private ArrayList familyList = new ArrayList();

        public Character()
        {
            firstName = "";
            lastName = "";
            age = 0;
            freeTime = 168; //7 days * 24 hrs/day = 168 hours
            job = null;
        }

        public string characterSummary()
        {
            string summary = firstName + " " + lastName + "is " + age + " years old."
                + "|Physical Health: " + characterPhysicalHealth.currentValue + " |"
                + "|Mental Health: " + characterMentalHealth.currentValue + " |"
                + "|Money: " + characterMoney.currentValue + " |";

            return summary;
        }

        public int calculateRemainingFreeTime(int freeTimeEffect)
        {
            freeTime = freeTime + freeTimeEffect;
            return freeTime;
        }

        public void addFriend(Character characterReceivingFriend, Character newFriend)
        {
            characterReceivingFriend.friendsList.Add(newFriend);
        }

        public void addFamily(Character characterReceivingFamily, Character newFamily)
        {
            characterReceivingFamily.familyList.Add(newFamily);
        }

        public void addTrait(Character characterReceivingTrait, CharacterTrait newTrait)
        {
            characterReceivingTrait.traitList.Add(newTrait);
        }

    }
}
