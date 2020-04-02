using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions_simpleLambdaExpressions
{
    delegate bool MeDelegate(int n);

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Print(numbers);

            var res = PutNumbersThroughGountlet(numbers, n => n > 5);
            Print(res);

            res = PutNumbersThroughGountlet(numbers, n => n < 10);
            Print(res);

            Console.ReadKey();
        }

        static IEnumerable<int> PutNumbersThroughGountlet (IEnumerable<int> numbers, MeDelegate gauntlet)
        {
            foreach (int item in numbers)
            {
                if (gauntlet(item))
                    yield return item;
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
