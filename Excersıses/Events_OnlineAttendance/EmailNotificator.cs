using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_OnlineAttendance
{
    public class EmailNotificator
    {
        OnlineAttendanceChecker checker = new OnlineAttendanceChecker();

        public EmailNotificator(OnlineAttendanceChecker ch)
        {
            checker = ch;
            checker.BannedAttendeeEvent += SendEmail;
        }

        public void SendEmail(string bannedName)
        {
            Console.WriteLine("Email sent to administration: Banned user {0} attempted to join.\n", bannedName);
        }
    }
}
