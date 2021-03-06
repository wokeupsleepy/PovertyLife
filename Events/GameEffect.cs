﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PovertyLife.Character;
using PovertyLife.Traits;

namespace PovertyLife.Events
{
    public class GameEffect
    {
        protected GameCharacter affectedCharacter;
        public virtual void ExecuteEffect() { }
    }

    public class GameEffectStat : GameEffect
    {
        public enum StatChangeType
        {
            MENTALHEALTH, PHYSICALHEALTH, MONEY
        }

        public StatChangeType ChangedStatType { get; set; }
        public int StatChangeMagnitude { get; set; }

        public GameEffectStat(GameCharacter inputAffectedCharacter, StatChangeType inputChangedStatType, int inputStatChangeMagnitude)
        {
            affectedCharacter = inputAffectedCharacter;
            ChangedStatType = inputChangedStatType;
            StatChangeMagnitude = inputStatChangeMagnitude;
        }

        public override void ExecuteEffect()
        {
            switch (ChangedStatType)
            {
                case StatChangeType.MENTALHEALTH:
                    affectedCharacter.CharacterMentalHealth.CurrentValue += StatChangeMagnitude;
                    break;
                case StatChangeType.PHYSICALHEALTH:
                    affectedCharacter.CharacterPhysicalHealth.CurrentValue += StatChangeMagnitude;
                    break;
                case StatChangeType.MONEY:
                    affectedCharacter.CharacterMoney.CurrentValue += StatChangeMagnitude;
                    break;
                default:
                    Console.WriteLine("USE A PROPER GameEffectStat statChangeType input value");
                    Console.ReadLine();
                    break;
            }
        }
    }

    public class GameEffectStatUpperThreshold : GameEffect
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

    public class GameEffectStatLowerThreshold : GameEffect
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

    public class GameEffectTrait : GameEffect
    {
        public GameEffectTrait(GameCharacter inputCharacter, CharacterTrait inputTrait)
        {
            inputCharacter.TraitList.Add(inputTrait);
        }
    }

    public class GameEffectAddFriendOrFamily : GameEffect
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

    public class GameEffectAddInventory : GameEffect
    {
        public GameEffectAddInventory(GameCharacter inputCharacter, PhysicalInventoryItem inputInventoryItem)
        {
            inputCharacter.PhysicalInventory.Add(inputInventoryItem);
        }
    }
}
