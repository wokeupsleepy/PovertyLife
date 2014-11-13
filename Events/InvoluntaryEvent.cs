using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PovertyLife.Character;

namespace PovertyLife.Events
{

    /* 
     * 
     * 
     * 
     */

    public class InvoluntaryEvent : GameEvent
    {
        GameCharacter AffectedCharacter { get; set; }
        HashSet<GameEffect> EventGameEffects { get; set; }
        string FlavorText { get; set; }

        public void ExecuteEffectsCharacter()
        {
            FlavorText = null;
        }
    }
}
