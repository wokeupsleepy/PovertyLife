using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PovertyLife.Events;

namespace PovertyLife.Traits
{
    class CharacterJob : CharacterTrait
    {
        public string JobName { get; set; }

        public CharacterJob(string inputJobName, GameEffect inputEffect)
        {
            JobName = inputJobName;
        }

    }
}
