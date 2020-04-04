using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_EventHandler
{
    public enum CowState
    {
        Awake,
        Sleeping
    }

    class CowTippedOverEventArgs : EventArgs
    {
        public CowState State { get; set; }
        public CowTippedOverEventArgs(CowState s)
        {
            State = s;
        }
    }

    class Cow
    {
        public string Name { get; set; }

        public event EventHandler<CowTippedOverEventArgs> Moo;

        public void BeTippedOver()
        {
            //some logic to tip over the cow.
            CowState currentState = new Random().Next() % 2 == 0 ? CowState.Awake : CowState.Sleeping;
            //raise an event
            if (Moo != null)
            {
                Moo(this, new CowTippedOverEventArgs(currentState));
            }   
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cow c1 = new Cow() { Name = "Betsy" };
            c1.Moo += Giggle;
            Cow c2 = new Cow() { Name = "Georgy" };
            c2.Moo += Giggle;
            Cow victim = new Random().Next() % 2 == 0 ? c1 : c2;
            victim.BeTippedOver();

            Console.ReadKey();
        }

        public static void Giggle(object sender, CowTippedOverEventArgs e)
        {
            Cow c = sender as Cow;
            Console.WriteLine("We tipped over " + c.Name +"!");
            Console.WriteLine("Giggle-giggle...");
            if (e.State == CowState.Awake)
                Console.WriteLine("Ruuuun!!!");
            else if (e.State == CowState.Sleeping)
                Console.WriteLine("Tickle " + c.Name);
        }
    }
}
