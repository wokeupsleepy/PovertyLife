﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PovertyLife.Character;

namespace PovertyLife.Events
{
    //Events should have a specific character target and a specific set of GameEffects that occur

    interface GameEvent
    {
        public GameCharacter AffectedCharacter { get; set; }
        public HashSet<GameEffect> EventGameEffects { get; set; }
        public string FlavorText { get; set; }

        public void ExecuteEffectsCharacter();
    }

}
