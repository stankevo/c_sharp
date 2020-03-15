using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_OnlineAttendance
{
    public class OnlineAttendanceChecker
    {
        public delegate void BannedAttendee(string value);
        public event BannedAttendee BannedAttendeeEvent;

        private static IList<string> bannedAttendees;

        public OnlineAttendanceChecker()
        {

        }

        public OnlineAttendanceChecker(IList<string> bannedNames)
        {
            bannedAttendees = new List<string>();
            bannedAttendees = bannedNames;
        }

        public void CheckAttendee (string name)
        {
            if (bannedAttendees.Contains(name))
            {
                if (BannedAttendeeEvent != null)
                    BannedAttendeeEvent(name);
            }
            else
            {
                Console.WriteLine("Welcome, {0}!\n", name);
            }
        }
    }
}
