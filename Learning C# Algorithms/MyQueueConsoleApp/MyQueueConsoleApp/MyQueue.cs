using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueueConsoleApp
{
    class MyQueue
    {
        private int MaxSize;
        private string[] Container;
        public int Top;
        public int Rear;
        private int CurrentSize;

        public MyQueue(int length)
        {
            MaxSize = length;
            Container = new string[MaxSize];
            Top = 0;
            Rear = -1;
            CurrentSize = 0;
        }

        public void Enqueue(string item)
        {
            if (CurrentSize < MaxSize)
            {
                if (Rear == MaxSize-1)
                {
                    Rear = -1;
                }
                Rear++;
                Container[Rear] = item;
                CurrentSize++;
            }
            else
            {
                Console.WriteLine("Cannot insert, the queue is full.");
            }
        }

        public string Dequeue()
        {
            if (CurrentSize > 0)
            {
                string firstElement = Container[Top];
                Top++;
                if (Top == MaxSize)
                {
                    Top = 0;
                }
                CurrentSize--; //  ??
                return firstElement;
            }
            else
            {
                Console.WriteLine("Cannot dequeue, the queue is empty.");
                return "";
            }
        }

        public void Display()
        {
            Console.WriteLine("Queue:");
            for (int i = 0; i < Container.Length; i++)
            {
                Console.WriteLine("[" + Container[i] + "]" + ((i == Top) ? "  <-- Top" : (i == Rear) ? "  <-- Rear" : ""));
            }
            Console.WriteLine();
        }

        public string PeekFront()
        {
            return Container[Top];
        }
    }
}
