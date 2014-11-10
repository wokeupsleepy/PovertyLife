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
        List<GameEffect> EventGameEffects { get; set; }
        string FlavorText { get; set; }

        public void ExecuteEffectsCharacter()
        {
            foreach (GameEffect g_effect in EventGameEffects)
            {
                g_effect.ExecuteEffect();
            }
        }
    }
}
