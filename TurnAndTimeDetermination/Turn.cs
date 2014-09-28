using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PovertyLife.TurnAndTimeDetermination
{
    class Turn : GameTimeInterface
    {
        private GameCalendar characterGameCalendar;
        private DateTime startTime;
        private DateTime endTime;

        public Turn(GameCalendar inputGameCalendar, DateTime inputStartTime)
        {
            characterGameCalendar = inputGameCalendar;
            startTime = inputStartTime;
            endTime = characterGameCalendar.AddMinutes(startTime, 15);
        }

        GameCalendar GameTimeInterface.CharacterGameCalendar
        {
            get
            {
                return characterGameCalendar;
            }
            set
            {
                characterGameCalendar = value;
            }
        }



    }
}
