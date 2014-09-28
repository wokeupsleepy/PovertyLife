using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PovertyLife
{
    class CharacterTrait
    {
        private string traitName;
        private ArrayList traitEffectList = new ArrayList();
        public int turnTicker;
        public Character affectedCharacter { get; set; }

        //need to add functionality for turnTicker
        //int turnTicker stays the same, it's the number of hours before the GameEffect goes
        //void tickDownTurns is the CURRENT number of ticks before the GameEffect goes
        //traitEffectList is the list of GameEffects linked to this trait

        public string hello = "Hello Github from Visual Studio."

        public CharacterTrait()
        {

        }

        public CharacterTrait(string inputName, Character inputCharacter)
        {
            traitName = inputName;
            affectedCharacter = inputCharacter;
        }

        private void tickDownTurns()
        {

        }

    }
}
