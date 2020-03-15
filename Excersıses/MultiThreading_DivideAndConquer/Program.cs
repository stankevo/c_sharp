using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreading_DivideAndConquer
{
    class Program
    {
        static int ArrLength = 500000;
        static byte[] arr = new byte[ArrLength];
        const int ThreadsNum = 2;
        static long[] results = new long[ThreadsNum+1];

        static void Main(string[] args)
        {
            Console.WriteLine("Program started...");
            Random random = new Random();

            // initialize array
            for (int i=0; i<ArrLength; i++)
            {
                arr[i] = (byte)random.Next(100);
            }
            Console.WriteLine("Big array created.");

            // count sum in one thread
            var watch = System.Diagnostics.Stopwatch.StartNew();
            long res = sum(arr);
            watch.Stop();
            var elapsedTime = watch.Elapsed;

            Console.WriteLine("Total sum counted by one thread is {0}. Time: {1}.", res, elapsedTime.ToString());

            // count via 4 threads
            //watch.Restart();
            var watch2 = System.Diagnostics.Stopwatch.StartNew();
            Thread[] threads = new Thread[ThreadsNum];
            long intervalLength = ArrLength / ThreadsNum;
            
            // start 4 threads
            for (int i=0; i<ThreadsNum; i++)
            {
                int n = i;
                long start = n * intervalLength;
                long end = n * intervalLength + intervalLength - 1;
                threads[n] = new Thread(() => sumInThread(n, start, end));
                threads[n].Start();
            }

            //// calcuate sum of remaining part of array if exists
            //if (ArrLength % ThreadsNum != 0)
            //{
            //    // count sum of remaining part
            //    int sum3 = 0;
            //    for (long i = 0; i < ArrLength % ThreadsNum; i++)
            //    {
            //        sum3 += arr[ArrLength - i - 1];
            //    }
            //    results[ThreadsNum] = sum3;
            //    Console.WriteLine("Remaining part sum: {0}", results[ThreadsNum]);
            //}
            //else
            //{
            //    Console.WriteLine("Array was divided between {0} threads without remaining part", ThreadsNum);
            //}

            // wait for threads to finish calculation
            for (int i = 0; i < ThreadsNum; i++)
            {
                threads[i].Join();
            }

            // sum up results from threads and the remaining part (if exists)
            long res2 = 0;
            for (int i = 0; i < results.Length; i++)
            {
                res2 += results[i];
            }

            watch2.Stop();
            var elapsedTime2 = watch2.Elapsed;
            Console.WriteLine("Total sum counted by 4 threads is {0}. Time: {1}.", res2, elapsedTime2.ToString());

            Console.ReadLine();
        }

        static long sum(byte[] array)
        {
            long sum = 0;
            for (int i=0; i<array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        static void sumInThread(int threadId, long start, long end)
        {
            long sum = 0;
            for (long i = start; i <= end; i++)
            {
                sum += arr[i];
            }
            results[threadId] = sum;
            //Console.WriteLine("Thread {0} finished calculation and returned {1}", threadId, sum);

        }
    }
}
