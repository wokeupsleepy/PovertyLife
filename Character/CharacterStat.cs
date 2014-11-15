using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PovertyLife.Character
{
    public class CharacterStat
    {
        public int CurrentValue { get; set; }
        public int LowerThreshold { get; set; }
        public int UpperThreshold { get; set; }

        //StatStates are adjectives to give the player an idea of how they are doing
        //In-game they won't be exposed to CurrentValue, thresholds, StatPoints, etc., StatState will give them an idea
        public string StatState { get; set; }

        public int StatPoints { get; set; }

        public int resolveStatPoints()
        {

            if (this.CurrentValue < this.LowerThreshold)
            {
                StatPoints = StatPoints - 1;
            }

            else if (this.CurrentValue > this.UpperThreshold)
            {
                this.StatPoints = this.StatPoints + 1;
            }

            return StatPoints;
        }

    }
}
