using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rolls = {2, 3, 4, 6, 8, 9, 13, 25, 31, 33, 43, 44, 45, 47};
            int result = Binary_Search(rolls, 31);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int Binary_Search(int[] arr,int x)
        {
            int l = arr.Length;
            int left = 0;
            int right = l - 1;

            while (left <= right)
            {
                var mid = (left + right) / 2;
                if (arr[mid]==x)
                {
                    return mid;
                }
                if (arr[mid] <x)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }
    }
}
