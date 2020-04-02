using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_simple_delegate
{
    delegate bool MeDelegate(int n);

    class Program
    {
        static bool LessThanFive(int n) { return n < 5; }
        static bool LessThanTen(int n) { return n < 10; }
        static bool GreaterThanSeven(int n) { return n > 7; }

        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            IEnumerable<int> results = PutNumbersThroughGountlet(numbers, LessThanFive);
            Print(results);

            results = PutNumbersThroughGountlet(numbers, LessThanTen);
            Print(results);

            results = PutNumbersThroughGountlet(numbers, GreaterThanSeven);
            Print(results);

            Console.ReadKey();
        }

        static IEnumerable<int> PutNumbersThroughGountlet (IEnumerable<int> numbers, MeDelegate gauntlet)
        {
            foreach (int number in numbers)
            {
                if (gauntlet(number))
                    yield return number;
            }
        }

        static void Print<T>(IEnumerable<T> sequence)
        {
            foreach (T item in sequence)
                Console.Write(item + " ");
            Console.WriteLine();
        }

    }
}
