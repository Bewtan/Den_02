using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            ReverseSort(arr);
            Console.WriteLine(arr[arr2[0] - 1]+ " "+ arr[arr2[1] - 1]);
        }

        private static void ReverseSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int max = i;
                for (int j = i + 1; j < arr.Length; j++)
                    if (Program.Less(arr[max], arr[j]))
                        max = j;
                Program.Swap(arr, i, max);
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
