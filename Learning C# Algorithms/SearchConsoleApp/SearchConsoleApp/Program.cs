using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            var b = new int[2] { 0, 1 };
            var c = new int[3] { 1, 2, 3 };
            var d = new int[1] { 3 };
            var e = new int[3];

            Console.WriteLine("Find 30 in array:");
            Display(a);
            Console.WriteLine("Result: " + SearchUtilities.BinarySearch(a, 30));

            Console.WriteLine("\nFind 1 in array:");
            Display(b);
            Console.WriteLine("Result: " + SearchUtilities.BinarySearch(b, 1));

            Console.WriteLine("\nFind 0 in array:");
            Display(b);
            Console.WriteLine("Result: " + SearchUtilities.BinarySearch(b, 0));

            Console.WriteLine("\nFind 2 in array:");
            Display(c);
            Console.WriteLine("Result: " + SearchUtilities.BinarySearch(c, 2));

            Console.WriteLine("\nFind 10 in array (this value is not there):");
            Display(c);
            Console.WriteLine("Result: " + SearchUtilities.BinarySearch(c, 10));

            Console.WriteLine("\nFind 3 in array:");
            Display(d);
            Console.WriteLine("Result: " + SearchUtilities.BinarySearch(d, 3));

            Console.WriteLine("\nFind 0 in array (this value is not there):");
            Display(d);
            Console.WriteLine("Result: " + SearchUtilities.BinarySearch(d, 0));

            Console.WriteLine("\nFind 3 in array:");
            Display(e);
            Console.WriteLine("Result: " + SearchUtilities.BinarySearch(e, 3));


            // C# Built-it binary serach:
            Console.WriteLine("\n\nC# Built-it binary serach:");
            Console.WriteLine("Find 90 in array:");
            Display(a);
            Console.WriteLine("Result: " + Array.BinarySearch(a, 90));


            Console.ReadLine();
        }

        public static void Display(Array arr)
        {
            Console.Write("{ ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("}");
        }
    }
}
