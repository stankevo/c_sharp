using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Inheritence
{
    
    class Base
    {
        public string Name { get; set; }
        // 1. inherit an event - possible
        public event EventHandler myBaseEvent;

        public void BaseMethod()
        {
            Console.WriteLine("Base method.");
            myBaseEvent(this, EventArgs.Empty);
        }

        public static void BaseStaticMethod()
        {
            Console.WriteLine("The BaseStatic method called...");
        }

    }

    class Derived : Base
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. inherit an event - possible
            Derived d = new Derived() { Name = "DerivedClassObject"};
            d.myBaseEvent += MyMethod;
            d.BaseMethod();


            // 2. parse number into string
            int n = 15;
            string s = n.ToString();
            string s1 = Convert.ToString(n);

            // 3. Try to call a static method from a derived class - possible
            Derived.BaseStaticMethod();

            Console.ReadKey();

            Type i = typeof(Int32);
        }

        static void MyMethod(object s, EventArgs e)
        {
            var d = s as Derived;
            Console.WriteLine("Run my Base method for the event sender " + d.Name);
        }
    }
}
 