﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PovertyLife.Character
{
    class MentalHealth : CharacterStat
    {
        string[] mentalHealthStates = new string[5] {"depressed", "sad", "normal", "content", "fulfilled"};

        public MentalHealth(int startingValue)
        {
            CurrentValue = startingValue;
        }

    }
}