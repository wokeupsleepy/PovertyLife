using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PovertyLife
{
    class CharacterJob : CharacterTrait
    {
        public string jobName { get; set; }

        public CharacterJob(string inputJobName, GameEffect inputEffect)
        {
            jobName = inputJobName;
        }

    }
}
