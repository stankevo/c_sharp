using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Base
    {
        public string Name { get; set; }
        public event EventHandler myBaseEvent;

        public void BaseMethod()
        {
            Console.WriteLine("Base method.");
            myBaseEvent(this, EventArgs.Empty);
        }

    }

    class Derived : Base
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Derived d = new Derived() { Name = "DerivedClassObject"};
            d.myBaseEvent += MyMethod;
            d.BaseMethod();
            Console.ReadKey();
        }

        static void MyMethod(object s, EventArgs e)
        {
            var d = s as Derived;
            Console.WriteLine("Rum my Base method for the event sender " + d.Name);
        }
    }
}
 