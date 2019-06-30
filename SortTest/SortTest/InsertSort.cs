using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortTest
{
    class InsertSort
    {
        public static void Sort<T>(T[] arr) where T : IComparable
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i;
                while (j >0 && Program.Less(arr[j], arr[j - 1]))
                {
                    Program.Swap(arr, j, j - 1);
                    j--;
                }
            }
            Console.WriteLine(String.Join(" ", arr));
        }

    }


 }

