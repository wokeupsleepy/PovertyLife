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
        void ExecuteEffectsCharacter();
    }

}
