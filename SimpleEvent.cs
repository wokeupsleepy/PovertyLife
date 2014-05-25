using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PovertyLife
{
    class SimpleEvent : Event
    {
        public SimpleEvent(string inputMessageText, Character inputCharacterAffected)
        {
            messageText = inputMessageText;
            characterAffected = inputCharacterAffected;
        }

    }

}
