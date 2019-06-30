using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halfiwe
{
    class Program
    {
        static void Main(string[] args)
        {
            string Useless = Console.ReadLine();
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Sort(arr);
            ReverseSort(arr);

        }



        private static void ReverseSort(int[] arr)
        {
            for (int i = arr.Length /2; i < arr.Length - 1; i++)
            {
                int max = i;
                for (int j = i + 1; j < arr.Length; j++)
                    if (Program.Less(arr[max], arr[j]))
                        max = j;
                Program.Swap(arr, i, max);
            }

            Console.WriteLine(String.Join(" ", arr));
        }
        public static void Sort<T>(T[] arr) where T : IComparable
        {
            for (int i = 0; i < (arr.Length /2) -1; i++)
            {
                int min = i;
                for (int j = i + 1; j < (arr.Length / 2); j++)
                    if (Program.Less(arr[j], arr[min]))
                        min = j;
                Program.Swap(arr, i, min);
            }

            //Console.WriteLine(String.Join(" ", arr));
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
