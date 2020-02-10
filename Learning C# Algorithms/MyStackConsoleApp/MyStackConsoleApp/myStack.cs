using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStackConsoleApp
{
    public class MyStack
    {
        private int MaxLength;
        private string[] Arr;
        public int Top;

        public MyStack(int length)
        {
            MaxLength = length;
            Arr = new string[MaxLength];
            Top = -1;
        }

        public void Push(string item)
        {
            if (Top < MaxLength - 1)
            {
                Top ++;
                Arr[Top] = item;
            }
            else
            {
                Console.WriteLine("Cannot push a new element as stack is full");
            }
        }

        public string Pop()
        {
            if (Top >= 0)
            {
                int old_top = Top;
                Top--;
                return Arr[old_top]; // we do not delete items from a stack, only moving the Top pointer up and down
            }
            else
            {
                Console.WriteLine("Cannot pop(), stack is empty.");
                return "";
            }
        }

        public string Peek()
        {
            return Arr[Top];
        }


        public void DisplayStack()
        {
            Console.WriteLine("Stack:");
            if (Arr[Top] != null)
            {
                for (int i = Top; i >= 0; i--)
                {
                    Console.WriteLine(Arr[i] + ((i== Top)? "  <- Top" : ""));
                }
            }
            else
            {
                Console.WriteLine("Stack is empty.");
            }
        }

    }
}
