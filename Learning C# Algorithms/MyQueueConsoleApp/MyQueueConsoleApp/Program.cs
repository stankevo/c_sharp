using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueueConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var q = new MyQueue(5);
            q.Enqueue("Max");
            q.Enqueue("Sara");
            q.Enqueue("Jery");

            q.Display();

            Console.WriteLine("Which element is on top? - " + q.PeekFront());
            Console.WriteLine("Dequeue: " + q.Dequeue());

            q.Display();

            Console.WriteLine("Enqueue an element: ");
            q.Enqueue("Vita");
            q.Display();
            Console.WriteLine("Enqueue an element: ");
            q.Enqueue("Tata");
            q.Display();
            Console.WriteLine("Enqueue an element: ");
            q.Enqueue("John");
            q.Display();


            Console.WriteLine("Dequeue: " + q.Dequeue());
            Console.WriteLine("Dequeue: " + q.Dequeue());
            Console.WriteLine("Dequeue: " + q.Dequeue());
            Console.WriteLine("Dequeue: " + q.Dequeue());

  
            Console.ReadLine();
  
        }
    }
}
