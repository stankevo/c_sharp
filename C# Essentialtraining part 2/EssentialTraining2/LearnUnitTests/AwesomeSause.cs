using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraining2
{
    public class AwesomeSaucse
    {
        public List<string> Sauces { get; set; }

        public AwesomeSaucse()
        {
            Sauces = new List<string>();
        }

        public bool IsAwesomeSouce(string sauseName)
        {
            return Sauces.Contains(sauseName);
        }
    }
}
