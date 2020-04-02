using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_basic_observer_pattern
{
    class TrainSignal
    {
        public event Action HereComesATrain; // this is the Action delegate

        public void TrainsAreComing()
        {
            // some logic for lights
            Console.WriteLine("Trains are coming...");
            if (HereComesATrain != null)
                HereComesATrain(); // Invoke the delegate
        }
    }

    class Car // Observer
    {
        public Car(TrainSignal trainSignal)
        {
            trainSignal.HereComesATrain += StopTheCar; // subscrie to the event and StopTheCar() when the event is raised. 
                                                  // In other vords, add StopTheCar method to the HereComesATrain delegate chain 
        }

        public void StopTheCar() // returns void, takes no arguments, so fits to the HereComesTheTrain delegate
        {
            Console.WriteLine("Screeetch!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TrainSignal signal = new TrainSignal();
            new Car(signal); // when a Car instance is created, it immediatelly subscribes to the HereComesATrain event
            new Car(signal);
            new Car(signal);
            new Car(signal);
            new Car(signal);

           // Console.WriteLine("Invocation list:");
           // foreach (Delegate del in signal.HereComesATrain)
           //     Console.WriteLine(del.Method.Name);
           // Console.WriteLine();

            signal.TrainsAreComing();
            Console.WriteLine();

            signal.TrainsAreComing();
            Console.WriteLine();

            signal.TrainsAreComing();

            Console.ReadKey();
        }
    }
}
