using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PovertyLife
{
    class GameEffect
    {
        protected Character affectedCharacter;
    }

    class GameEffectStat : GameEffect
    {
        public GameEffectStat(Character inputCharacter, int statChangeType, int statChangeMagnitude)
        {
            affectedCharacter = inputCharacter;
            switch (statChangeType)
            {
                case 1:
                    affectedCharacter.characterMentalHealth.currentValue += statChangeMagnitude;

                    break;
                case 2:
                    affectedCharacter.characterPhysicalHealth.currentValue += statChangeMagnitude;
                    break;
                case 3:
                    affectedCharacter.characterMoney.currentValue += statChangeMagnitude;
                    break;
                default:
                    Console.WriteLine("USE A PROPER GameEffectStat statChangeType input value");
                    Console.ReadLine();
                    break;
            }
        }
    }

    class GameEffectTrait : GameEffect
    {
        public GameEffectTrait(Character inputCharacter, CharacterTrait inputTrait)
        {
            inputCharacter.traitList.Add(inputTrait);
        }
    }

    class GameEffectAddFriendFamily : GameEffect
    {
        public GameEffectAddFriendFamily(Character inputCharacter, Character newConnectionCharacter, bool isFamily)
        {
            if (isFamily == true)
            {
                inputCharacter.familyList.Add(newConnectionCharacter);
            }
            else
            {
                inputCharacter.friendsList.Add(newConnectionCharacter);
            }
        }
    }

    class GameEffectAddInventory : GameEffect
    {
        public GameEffectAddInventory(Character inputCharacter, PhysicalInventoryItem inputInventoryItem)
        {
            inputCharacter.physicalInventory.Add(inputInventoryItem);
        }
    }
}
