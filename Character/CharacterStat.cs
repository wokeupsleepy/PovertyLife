using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PovertyLife
{
    class CharacterStat
    {
        public int currentValue { get; set; }
        public int lowerThreshold { get; set; }
        public int upperThreshold { get; set; }

        public string statState { get; set; }

        public int statPoints { get; set; }

        public int resolveStatPoints()
        {

            if (this.currentValue < this.lowerThreshold)
            {
                statPoints = statPoints - 1;
            }

            else if (this.currentValue > this.upperThreshold)
            {
                this.statPoints = this.statPoints + 1;
            }

            return statPoints;
        }

    }
}
