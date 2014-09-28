using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PovertyLife.TurnAndTimeDetermination
{
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
