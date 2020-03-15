using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Multithreading_Restaurant
{
    class Program
    {
        private static int ThreadsNumber = 3;
        private static object baton = new object();

        static void Main(string[] args)
        {
            Thread[] threads = new Thread[ThreadsNumber];

            for (int i=0; i<ThreadsNumber; i++)
            {
                int n = i;
                threads[i] = new Thread(() => UseBathroom(n));
                threads[i].Start();
            }
            
            for (int i = 0; i < ThreadsNumber; i++)
            {
                threads[i].Join();
            }
            Console.WriteLine("All threads are gone.");
            Console.ReadLine();
        }

        static void UseBathroom(int threadNumber)
        {
            int someTime = new Random().Next(500, 2000);
            int otherSomeTime = new Random().Next(500, 2000);
            for (int i=0; i<5; i++)
            {
                lock (baton)
                {
                    Console.WriteLine("Thread #{0} entered the bathroom.", threadNumber);
                    Thread.Sleep(someTime);
                    Console.WriteLine("Thread #{0} left.", threadNumber);
                }
                Thread.Sleep(otherSomeTime);
            }

            Thread.Sleep(otherSomeTime);
            Console.WriteLine("Thread #{0} left from restaurant.", threadNumber);

        }
    }
}
