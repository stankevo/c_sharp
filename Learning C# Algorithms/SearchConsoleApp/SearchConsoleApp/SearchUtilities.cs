using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchConsoleApp
{
    public class SearchUtilities
    {
        public static int BinarySearch(int[] arr, int value)
        {
            return BinarySearchReq(arr, value, 0, arr.Length - 1);
        }

        private static int BinarySearchReq(int[] arr, int value, int start, int end)
        {
            if (start <= end)
            {
                int q = (start + end) / 2;

                if (arr[q] == value)
                {
                    return q;
                }
                else if (value < arr[q])
                {
                    return BinarySearchReq(arr, value, start, q - 1);
                }
                else
                {
                    return BinarySearchReq(arr, value, q + 1, end);
                }
            }
            else
            {
                return -1;
            }
        }

        public static int LinearSearch (int [] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                    return i;
            }
            return -1;
        }
    }
}
