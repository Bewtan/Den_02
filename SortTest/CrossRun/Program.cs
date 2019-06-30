using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossRun
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr3 = new int[arr.Length + arr2.Length];
            arr.CopyTo(arr3, 0);
            arr2.CopyTo(arr3, arr.Length);
            Sort(arr3);

        }
        public static void Sort<T>(T[] arr) where T : IComparable
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
        public static void Swap<T>(T[] arr, int first, int second)
        {
            T temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
            /*Console.WriteLine(arr[second] +"<->" +arr[first]);
            Console.WriteLine(String.Join(" ", arr));*/
        }

        public static bool Less(IComparable first, IComparable second)
        {
            return first.CompareTo(second) < 0;
        }
    }
}
