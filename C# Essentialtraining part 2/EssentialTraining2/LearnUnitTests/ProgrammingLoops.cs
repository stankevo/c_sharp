using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraining2
{
    public class ProgrammingLoops
    {
        public int ForLoop()
        {
            int sum = 0;
            for (var i=0; i<100; i++)
            {
                sum = sum + i;
            }
            return sum;
        }

        public int ForEachLoop()
        {
            var numbers = new List<int> { 1, 3, 5, 7, 9 };
            var sum = 0;
            foreach(var number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public int WhileLoop()
        {
            int sum = 0;
            int counter = 0;
            while(counter < 100)
            {
                sum += counter;
                counter++;
            }
            return sum;
        }

        public int DoWhileLoop()
        {
            int sum = 0;
            int counter = 0;
            do
            {
                sum += counter;
                counter++;
            } while (counter < 100);
            return sum;
        }

        public string BreakAndContinue()
        {
            var grosseryList = new List<string> { "Bread", "Milk", "Eggs", "Cheese", "Apples" };
            var sb = new StringBuilder();
            foreach (var item in grosseryList)
            {
                if (item.StartsWith("M")) continue;

                if (item.StartsWith("C")) break;

                sb.AppendLine(item);
            }
            return sb.ToString();
        }

    }
}
