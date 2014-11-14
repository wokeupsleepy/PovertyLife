using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PovertyLife.Character;

namespace PovertyLife.Events
{

    /* 
     * InvolutaryEvent objects are accidental effects
     * Can perform the following things:
     * Add GameEffect to EventGameEffects,
     * execute all GameEffect objects in EventGameEffects,
     * display FlavorText in game interface,
     * support user choice,
     * support probability rolls based on user choices,
     * support chaining InvoluntaryEvents and choosing to initiate VoluntaryEvents
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
