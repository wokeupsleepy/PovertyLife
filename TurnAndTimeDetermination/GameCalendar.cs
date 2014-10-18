using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PovertyLife.TurnAndTimeDetermination
{
    /*
     * Purpose of the GameCalendar: Keep track of dates and times that are important to the Character.
     * For example, every Character would have a pay schedule, a rent schedule, perhaps a schedule where they need to take pills, etc.
     * It would also keep track of anniversaries, important Character-to-Character plans (date night, school exam, etc.)
     * Think of it like a planner, alarm clock, etc.
     */

    class GameCalendar : GregorianCalendar
    {
        public DateTime CurrentTime { get; set; }
        public DateTime ImportantDate { get; set; }

        public GameCalendar(DateTime inputDateTime)
        {
            CurrentTime = inputDateTime;
        }

        public bool CheckDateTimesSameDate(DateTime firstDateTime, DateTime secondDateTime)
        {
            return firstDateTime.Date == secondDateTime.Date;
        }

    }
}
