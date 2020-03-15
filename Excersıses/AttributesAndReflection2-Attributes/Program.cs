using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesAndReflection2_Attributes
{
    class MeAttribute : Attribute // this is a type
    {
        public MeAttribute(int value, string secondValue) // constructor
        {
            Console.WriteLine("MeAttribute()");
            Console.WriteLine(value);
            Console.WriteLine(secondValue);
        }

        public int SomeIntProperty { get; set; }
        public char SomeCharProperty { get; set; }
    }

    [Me(25, "Jamie King", SomeCharProperty = 'J', SomeIntProperty = 72)] // we can provide parameters to the constructor and instantiate other properties
    class Program
    {
        static void Main(string[] args)
        {
            typeof(Program).GetCustomAttributes(false);
            Console.ReadLine();
        }
    }
}
