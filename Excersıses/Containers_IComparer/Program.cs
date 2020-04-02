using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containers_IComparer
{
    // This class is using the IComparable<T> interface
    public class Cow : IComparable<Cow>
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        static Random ran = new Random(100);

        public Cow(string cowName)
        {
            Name = cowName;
            Weight = ran.Next(500, 1000);
        }

        public int CompareTo(Cow other)
        {
            return Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            return Name + ": " + Weight;
        }
    }

    // This is the way to use IComparer<T> if you want
    public class CowComparer : IComparer<Cow>
    {
        public int Compare(Cow left, Cow right)
        {
            return left.Weight - right.Weight;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Cow> meCows = new List<Cow> {
                new Cow("Betsy"), new Cow("Georgy"),
                new Cow("Abby"),  new Cow("Doug"),
                new Cow("Bacon"), new Cow("Beef")
            };
            meCows.ForEach(Console.WriteLine);

            // Sorting by Names via IComparable<T>
            meCows.Sort();
            Console.WriteLine(); 
            meCows.ForEach(Console.WriteLine);

            // Sorting by Wight via IComparer<T>
            meCows.Sort(new CowComparer());
            Console.WriteLine();
            meCows.ForEach(Console.WriteLine);

            Console.ReadKey();
        }
    }
}
