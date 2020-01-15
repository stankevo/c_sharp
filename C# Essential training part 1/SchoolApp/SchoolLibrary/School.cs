using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class School
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }

        private string _twitterAddress;
        public string TwitterAddress
        {
            get { return _twitterAddress; }
            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                } else
                {
                    throw new Exception("The twitter address should start with @.");
                }
            }
        }

        public School()
        {
            Name = "Untitled School";
            PhoneNumber = "555-1234"; 
        }

        public School(string SchoolName, string SchoolPhoneNumber)
        {
            Name = SchoolName;
            PhoneNumber = SchoolPhoneNumber;
        }

        public static float AverageThreeScores(float a, float b, float c)
        {
            var res = ( a + b + c ) / 3;
            return res;
        }

        public static int AverageThreeScores(int a, int b, int c)
        {
            var res = ( a + b + c ) / 3;
            return res;
        }

        // Function bodied expression
        public static double AverageThreeScores (double a, double b, double c) => ( a + b + c ) / 3;

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine(Address);
            sb.AppendLine(City);
            sb.Append(", ");
            sb.Append(State);
            sb.Append("  ");
            sb.Append(Zip);
            sb.AppendLine(PhoneNumber);
            sb.AppendLine(TwitterAddress);
            
            return sb.ToString();
        }
    }
}
