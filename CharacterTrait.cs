using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PovertyLife
{
    class CharacterTrait
    {
        public string traitName { get; set; }
        public GameEffect traitEffect { get; set; }

        public CharacterTrait(string inputName, GameEffect inputEffect)
        {
            traitName = inputName;
            traitEffect = inputEffect;
        }
    }
}
