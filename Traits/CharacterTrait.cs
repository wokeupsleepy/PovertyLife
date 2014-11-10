using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using PovertyLife.Character;

namespace PovertyLife.Traits
{
    public class CharacterTrait
    {
        public string TraitName { get; set; }
        private ArrayList traitEffectList = new ArrayList();

        public int TurnTicker { get; set; }
        public GameCharacter affectedCharacter { get; set; }

        //need to add functionality for turnTicker
        //int turnTicker stays the same, it's the number of hours before the GameEffect goes
        //void tickDownTurns is the CURRENT number of ticks before the GameEffect goes
        //traitEffectList is the list of GameEffects linked to this trait

        public CharacterTrait()
        {

        }

        public CharacterTrait(string inputName, GameCharacter inputCharacter, int inputTurnTicker)
        {
            TraitName = inputName;
            affectedCharacter = inputCharacter;
            TurnTicker = inputTurnTicker;
        }

        private void tickDownTurns()
        {
            this.TurnTicker = this.TurnTicker - 1;
        }

    }
}
