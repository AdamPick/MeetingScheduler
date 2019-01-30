using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingScheduler
{
    class participant
    {
        private int participantId;
        private string name;

        public participant(int participantId, string name)
        {
            this.participantId = participantId;
            this.name = name;
        }
    }
}
