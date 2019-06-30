using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortTest
{
    public class SelectionSort
    {
        public static void Sort<T>(T[] arr) where T:IComparable
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                    if (Program.Less(arr[j], arr[min]))
                        min = j;
                Program.Swap(arr, i, min);
            }

            Console.WriteLine(String.Join(" ", arr));
        }

        public static void Sort<T>(T[] arr,int first) where T : IComparable
        {
            if (first >= arr.Length - 1)
            {
                Console.WriteLine(String.Join(" ", arr));
                return;
            }
            int min = first;
            for (int i = first;i< arr.Length; i++)
            {
                if (Program.Less(arr[i], arr[min]))
                    min = i;
            }
            Program.Swap(arr, min, first);
            Sort(arr, first + 1);
        }



    }
}
