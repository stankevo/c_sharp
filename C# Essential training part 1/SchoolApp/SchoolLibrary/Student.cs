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
    }
}
