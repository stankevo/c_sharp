using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_OnlineAttendance
{
    public class Alarm
    {
        private OnlineAttendanceChecker checker;

        public Alarm(OnlineAttendanceChecker ch) 
        {
            checker = ch;
            checker.BannedAttendeeEvent += RaiseAlarm;
        }

        public void RaiseAlarm(string name)
        {
            Console.WriteLine("Alarm! Blocked user {0} attempted to join.", name);
        }
    }
}
