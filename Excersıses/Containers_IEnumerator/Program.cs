using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containers_IEnumerator
{
    class Program
    {
        //Create a generic custom list (based on an array in this example and the GetEnumerator() method,
        //so that the foreach loop could be used on this list.
        // + Add() method to add elements into the list

        public class MeList<T>: IEnumerable<T>
        {
            T[] items = new T[5];
            int count;

            public void Add(T item)
            {           
                if (count > items.Length)
                    Array.Resize(ref items, items.Length * 2);
                items[count] = item;
                count++;
            }

            public IEnumerator<T> GetEnumerator()
            {
                // If using yield return (easier and recommended)
                for (int i = 0; i < count; i++)
                    yield return items[i];

                // What if we didn't use yield return? - It's is not recommended.
                // Anyway, if we do it, we would have to implement our own enumerator
                // - the nested class MeEnumerator, that implements the IEnumerator<T> interface (see below).

                //return new MeEnumerator(this);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
                // here the GetEnumerator is returning the generic IEnumerator<>. 
                // But, the generic IEnumerator<> implements the non-generic version of IEnumerator.
                // it means that it will cast automatiocally (covariance in generics?)
            }

            // Indexer
            public T this[int index]
            {
                get
                {
                    CheckBoundaries(index);
                    return items[index];
                }
                set
                {
                    CheckBoundaries(index);
                    items[index] = value;
                }
            }

            void CheckBoundaries(int index)
            {
                if (index < 0 || index >= count)
                    throw new IndexOutOfRangeException();
            }

            // this code is used only if we decide to not use yield return in GetEnumerator().
            // Don't do like this!
            class MeEnumerator : IEnumerator<T>
            {
                int index = -1;
                MeList<T> theList;

                public MeEnumerator(MeList<T> list)
                {
                    theList = list;
                }

                public T Current
                {
                    get
                    {
                        if (index < 0 || index >= theList.count)
                            return default(T);
                        return theList.items[index];
                    }
                }

                object IEnumerator.Current
                {
                    get { return this.Current; } 
                }


                public void Dispose()
                {

                }

                public bool MoveNext()
                {
                    if (index + 1 >= theList.count)
                        return false; // index out of range
                    else
                    {
                        index++;
                        return true;
                    }
                }

                public void Reset()
                {
                    throw new NotImplementedException();
                }
            }
        }


        static void Main(string[] args)
        {
            var myPartyAges = new MeList<int> { 25, 34, 32 }; //we can use the short-hand syntax, because MeList<int> implements IEnumerable<T>
            foreach (int item in myPartyAges) //we can use foreach loop, because MeList has GetEnumerator() method.
                Console.WriteLine(item);

            // with Indexer (see above) it is also possible to reference items by index
            myPartyAges[0] = 26;
            Console.WriteLine("myPartyAges[0] = " + myPartyAges[0]);


            Console.ReadLine(); 
        }
    }
}
