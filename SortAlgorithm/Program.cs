using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rolls = {4, 20, 5, 16, 18, 13, 9, 15, 10};

            var result_array = SelectionSort(rolls);
            Console.WriteLine(string.Join("<", result_array));
            Console.ReadLine();
        }

        public static int[] SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i= 0;  i < n; i++)
            {
                var minIndex = i;

                for (int j = i+1; j < n; j++)
                {
                    if (arr[j]< arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    var temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }
            return arr;
        }
    }
}
