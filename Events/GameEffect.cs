using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PovertyLife.Character;
using PovertyLife.Traits;

namespace PovertyLife.Events
{
    class GameEffect
    {
        protected GameCharacter affectedCharacter;
    }

    class GameEffectStat : GameEffect
    {
        public GameEffectStat(GameCharacter inputCharacter, int statChangeType, int statChangeMagnitude)
        {
            affectedCharacter = inputCharacter;
            switch (statChangeType)
            {
                case 1:
                    affectedCharacter.CharacterMentalHealth.CurrentValue += statChangeMagnitude;
                    break;
                case 2:
                    affectedCharacter.CharacterPhysicalHealth.CurrentValue += statChangeMagnitude;
                    break;
                case 3:
                    affectedCharacter.CharacterMoney.CurrentValue += statChangeMagnitude;
                    break;
                default:
                    Console.WriteLine("USE A PROPER GameEffectStat statChangeType input value");
                    Console.ReadLine();
                    break;
            }
        }
    }

    class GameEffectStatUpperThreshold : GameEffect
    {
        public GameEffectStatUpperThreshold(GameCharacter inputCharacter, int statChangeType, int upperThresholdChange)
        {
            affectedCharacter = inputCharacter;
            switch (statChangeType)
            {
                case 1:
                    affectedCharacter.CharacterMentalHealth.UpperThreshold += upperThresholdChange;
                    break;
                case 2:
                    affectedCharacter.CharacterPhysicalHealth.UpperThreshold += upperThresholdChange;
                    break;
                case 3:
                    affectedCharacter.CharacterMoney.UpperThreshold += upperThresholdChange;
                    break;
                default:
                    Console.WriteLine("USE A PROPER GameEffectStatUpperThreshold statChangeType input value");
                    Console.ReadLine();
                    break;
            }
        }
    }

    class GameEffectStatLowerThreshold : GameEffect
    {
        public GameEffectStatLowerThreshold(GameCharacter inputCharacter, int statChangeType, int lowerThresholdChange)
        {
            affectedCharacter = inputCharacter;
            switch (statChangeType)
            {
                case 1:
                    affectedCharacter.CharacterMentalHealth.LowerThreshold += lowerThresholdChange;
                    break;
                case 2:
                    affectedCharacter.CharacterPhysicalHealth.LowerThreshold += lowerThresholdChange;
                    break;
                case 3:
                    affectedCharacter.CharacterMoney.LowerThreshold += lowerThresholdChange;
                    break;
                default:
                    Console.WriteLine("USE A PROPER GameEffectStatLowerThreshold statChangeType input value");
                    Console.ReadLine();
                    break;
            }
        }
    }

    class GameEffectTrait : GameEffect
    {
        public GameEffectTrait(GameCharacter inputCharacter, CharacterTrait inputTrait)
        {
            inputCharacter.TraitList.Add(inputTrait);
        }
    }

    class GameEffectAddFriendOrFamily : GameEffect
    {
        public GameEffectAddFriendOrFamily(GameCharacter inputCharacter, GameCharacter newConnectionCharacter, bool isFamily)
        {
            if (isFamily == true)
            {
                inputCharacter.FamilyList.Add(newConnectionCharacter);
            }
            else
            {
                inputCharacter.FriendsList.Add(newConnectionCharacter);
            }
        }
    }

    class GameEffectAddInventory : GameEffect
    {
        public GameEffectAddInventory(GameCharacter inputCharacter, PhysicalInventoryItem inputInventoryItem)
        {
            inputCharacter.PhysicalInventory.Add(inputInventoryItem);
        }
    }
}
