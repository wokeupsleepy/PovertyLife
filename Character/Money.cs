using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PovertyLife.Character
{
    public class Money : CharacterStat
    {
        string[] moneyStates = new string[5] {"broke", "unstable", "stable", "solvent", "comfortable" };

        //use this to change the "buying value" of current funds so that it is reflected in moneyStates
        public int LocationFundsModifier { get; set; }
        
        public Money(int startingValue)
        {
            CurrentValue = startingValue;
        }

    }
}
