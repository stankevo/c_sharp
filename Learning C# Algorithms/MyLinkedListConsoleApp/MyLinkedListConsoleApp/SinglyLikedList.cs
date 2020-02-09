using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedListConsoleApp
{
    public class SinglyLikedList
    {
        public Node Head { get; set; }

        public void InsertFirst(int value)
        {
            Node newNode = new Node
            {
                Value = value,
                Next = Head
            };

            Head = newNode;
        }

        public void DeleteFirst()
        {
            try
            {
                Head = Head.Next;
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("There are no more elements in list");
            }
        }
        
        public void DisplayList()
        {
            var item = Head;
            while (item != null) 
            {
                Console.WriteLine("< " + item.Value + ", " + ((item.Next != null)? item.Next.Value.ToString() : "_") + " >");
                item = item.Next;
            }
        }

        public void InsertLast(int value)
        {
            var newItem = new Node
            {
                Value = value
            };

            var item = Head;
            while (item.Next != null)
            {
                item = item.Next;
            }
            item.Next = newItem;
        }
    }


}
