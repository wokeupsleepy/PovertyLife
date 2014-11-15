using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PovertyLife.Character
{
    public class MentalHealth : CharacterStat
    {
        //all statStates 
        string[] mentalHealthStates = new string[5] {"depressed", "sad", "okay", "content", "fulfilled"};

        public MentalHealth(int startingValue)
        {
            CurrentValue = startingValue;
        }

    }
}
