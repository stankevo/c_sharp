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
        static long ArrLength = 500000000;
        static byte[] arr = new byte[ArrLength];
        static int ThreadsNum = Environment.ProcessorCount;
        static long[] results = new long[ThreadsNum+1];

        static long intervalLength = ArrLength / ThreadsNum;

        static void Main(string[] args)
        {
            Console.WriteLine("Program started...");
            Console.WriteLine("Processors: " + ThreadsNum);
            Random random = new Random(987);

            // initialize array
            Console.WriteLine("Initializing the array of {0} numbers...", ArrLength);
            for (int i=0; i<arr.Length; i++)
            {
                arr[i] = (byte)random.Next(10);
            }
            Console.WriteLine("Initialization done.");

            // count sum in one thread
            Console.WriteLine("Summing up in one thread...");
            var watch = System.Diagnostics.Stopwatch.StartNew();
            long res = sum(arr);
            watch.Stop();
            var elapsedTime = watch.Elapsed;

            Console.WriteLine("Total sum counted by one thread is {0}. Time: {1}.", res, elapsedTime.ToString());

            // count via several threads threads
            var watch2 = System.Diagnostics.Stopwatch.StartNew();
            Thread[] threads = new Thread[ThreadsNum];
            
            // start threads
            for (int i=0; i<ThreadsNum; i++)
            {
                threads[i] = new Thread(SumYourPortion);
                threads[i].Start(i);
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
            Console.WriteLine("Total sum counted by {0} threads is {1}. Time: {2}.", ThreadsNum, res2, elapsedTime2.ToString());

            Console.WriteLine("Press any key to close the program.");
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
        }

        static void SumYourPortion(object portionNumber)
        {
            long sum = 0;
            int k = (int)portionNumber;
            long start = k * intervalLength;
            long end = k * intervalLength + intervalLength;
            for (long i = start; i < end; i++)
            {
                sum += arr[i];
            }
            results[k] = sum;
        }
    }
}
