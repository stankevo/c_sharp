using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreading_write_1_2_3_4
{
    class Program
    {
        static int ThreadsNumber = System.Environment.ProcessorCount; // 4
        static int i = -1;
        private static readonly object baton = new object();

        static void Main(string[] args)
        {
            Console.WriteLine("Number of threades: " + ThreadsNumber);

            for (int i = 0; i<ThreadsNumber; i++)
            {
                new Thread(WriteNextNumber).Start();
                Thread.Sleep(300);
            }

            Console.ReadLine();


        }

        static void WriteNextNumber()
        {
            while (true)
            {
                lock(baton)
                {
                    i++;
                    Console.WriteLine("Thred {0} is incremeting and writing {1}", Thread.CurrentThread.ManagedThreadId, i);
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
