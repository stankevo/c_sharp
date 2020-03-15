// https://www.completecsharptutorial.com/basic/c-event-handling-exercises.php
// Qu: Write a program for Online Attendance. The conditions are as follow:
//     User provides their name as Input and then application show message to "Welcome to their Name".
//     Jack, Steven and Mathew are banned for the organization.
//     So, when any user enters Jack, Steven and Mathew as user name,
//     the application raised an event and fire alarm as well as sends email to administration.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_OnlineAttendance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> banned = new List<string> { "Jack", "Steven", "Mathew" };
            OnlineAttendanceChecker checker = new OnlineAttendanceChecker(banned);

            Alarm alarm = new Alarm(checker);
            EmailNotificator notoficator = new EmailNotificator(checker);

            List<string> attendees = new List<string> { "Ann", "Lena", "Steven", "John" };

            foreach (string name in attendees)
            {
                checker.CheckAttendee(name);
            }

            Console.ReadLine();
        }
    }


}
