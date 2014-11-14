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
        GameCharacter affectedCharacter;
        List<GameEffect> eventGameEffects;
        EventChain eventChainInitiator;

        public List<GameEffect> EventGameEffects
        {
            get
            {
                return eventGameEffects;
            }
            set
            {
                eventGameEffects = value;
            }
        }
        public GameCharacter AffectedCharacter
        {
            get
            {
                return affectedCharacter;
            }
            set
            {
                affectedCharacter = value;
            }
        }
        public EventChain EventChainInitiator
        {
            get
            {
                return eventChainInitiator;
            }
            set
            {
                eventChainInitiator = value;
            }
        }

        public void ExecuteEffectsOnCharacter()
        {
            foreach (GameEffect g_effect in eventGameEffects)
            {
                g_effect.ExecuteEffect();
            }
        }

    }
}
