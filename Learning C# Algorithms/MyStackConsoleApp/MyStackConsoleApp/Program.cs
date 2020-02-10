using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStackConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new MyStack(10);
            a.Push("cookie");
            a.Push("chokolate");
            a.Push("banana");
            a.Push("sugar");
            a.Push("apple");

            a.DisplayStack();

            Console.WriteLine("\nUse pop: " + a.Pop() + "\n");
            a.DisplayStack();

            Console.WriteLine("\nFill in untill stack is full:");
            a.Push("1");
            a.Push("2");
            a.Push("3");
            a.Push("4");
            a.Push("5");
            a.Push("6");
            a.Push("7");
            a.DisplayStack();

            Console.WriteLine("\nPeek the top element:");
            Console.WriteLine("\nUse peek(): " + a.Peek() + "\n");
            a.DisplayStack();


            Console.WriteLine("\nPop until stack is empty:");
            for (int i=9; i>=0; i--)
            {
                Console.WriteLine("Pop: " + a.Pop());
            }
            Console.WriteLine("\nTry to pop unce again:");
            Console.WriteLine("Pop: " + a.Pop());

            //Console.WriteLine("\n\nUse c# built in stack:\n");
            //var s = new Stack<string> {
            //"cookie");
            //a.Push("chokolate");
            //a.Push("banana");
            //a.Push("sugar");
            //a.Push("apple"}

            Console.ReadLine();
        }
    }
}
