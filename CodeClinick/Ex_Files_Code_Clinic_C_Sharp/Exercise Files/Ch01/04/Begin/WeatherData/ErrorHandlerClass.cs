using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Weather
{
    public class ErrorHandlerClass
    {
        public delegate void SendErrorMessageToDebugConsole(string message);

        public static void SendErrorMessageToDebugConsole1(string text)
        {
            Debug.WriteLine("!!! THIS IS SendErrorMessageToConsole1: " + text);
        }

        public static void SendErrorMessageToDebugConsole2(string text)
        {
            Debug.WriteLine("!!! THIS IS SendErrorMessageToConsole2: " + text);
        }
    }
}
