using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortTest
{
    class BubbleSort
    {
        public static void Sort<T>(T[] arr) where T : IComparable
        {
            for (int i = 0; i < arr.Length-1; i++)
            { 
                for (int j = 0; j < arr.Length -i-1; j++)
                    if (Program.Less(arr[j+1],arr[j]))
                        Program.Swap(arr, j, j+1);
            }

            Console.WriteLine(String.Join(" ", arr));
        }


    }
}
