using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedListConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLikedList a = new SinglyLikedList();
            a.InsertFirst(1005);
            a.InsertFirst(1004);
            a.InsertFirst(1003);
            a.InsertFirst(1002);
            a.InsertFirst(1001);

            Console.WriteLine("List a:");
            a.DisplayList();

            Console.WriteLine("");
            Console.WriteLine("Delete first:");
            a.DeleteFirst();
            a.DisplayList();

            Console.WriteLine("");
            Console.WriteLine("Insert last:");
            a.InsertLast(1006);
            a.DisplayList();

            Console.WriteLine("");
            Console.WriteLine("Delete 5 elements one by one:");
            a.DeleteFirst();
            a.DeleteFirst();
            a.DeleteFirst();
            a.DeleteFirst();
            a.DeleteFirst();
            a.DeleteFirst();

            a.DisplayList();



            Console.WriteLine("");
            Console.WriteLine("Use c# built in lists:");
            var b = new LinkedList<int>();
            b.AddFirst(2001);
            b.AddLast(2002);
            b.AddAfter(b.Find(2001), 20015);

            var item = b.First;
            while (item != null)
            {
                Console.WriteLine("< " + item.Value + ", " + ((item.Next != null) ? item.Next.Value.ToString() : "_") + " >");
                item = item.Next;
            }

            Console.ReadLine();
        }
    }
}
