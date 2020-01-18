using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class Student : Person
    {
        public enum GradeLevel { FreshMan, Sophomore, Junior, Senior }
        public GradeLevel grade { get; set; }

        public override float ComputeGradeAverage()
        {
            // fix the implementation later
            return 4.0f;
        }

        public override string SendMessage(string message)
        {
            var initialMessage = base.SendMessage(message);
            var sb = new StringBuilder(initialMessage);
            sb.AppendLine("This message is private and confidential.");
            return sb.ToString();
        }
    }
}
