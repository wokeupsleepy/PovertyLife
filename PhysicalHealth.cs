using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PovertyLife
{
    class PhysicalHealth : CharacterStat
    {
        string[] physicalHealthStates = new string[5] {"exhausted", "tired", "healthy", "active", "fit" };

        string[] weightState = new string[5] {"skeletal","thin","average","overweight","obese" };
        
        public PhysicalHealth(int startingValue)
        {
            currentValue = startingValue;
        }

    }
}
