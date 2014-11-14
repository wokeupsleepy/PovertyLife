using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PovertyLife.Character;

namespace PovertyLife.Events
{
    //Events should have a specific character target and a specific set of GameEffects that occur

    public interface GameEvent
    {
        GameCharacter AffectedCharacter { get; set; }
        List<GameEffect> EventGameEffects { get; set; }
        string FlavorText { get; set; }

        //This states the beginning of an EventChain,
        //If it's another link in an EventChain, that won't need to be stated
        EventChain EventChainInitiator { get; set; }

        void ExecuteEffectsOnCharacter();
    }

}
