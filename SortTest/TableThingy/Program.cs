using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableThingy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] matrix = new int[arr[0], arr[1]];




        }

        public static void Sort<T>(T[,] arr) where T : IComparable
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
        public static void Swap<T>(T[,] arr, int first, int second)
        {
            T[] temp = new T[arr.GetLength(1)];
            for(int i = 0;i < temp.Length; i++)
            {
                temp[i] = arr[i, first];
                arr[i, first] = arr[i, second];
                arr[i, second] = temp[i];
            }
            /*Console.WriteLine(arr[second] +"<->" +arr[first]);
            Console.WriteLine(String.Join(" ", arr));*/
        }

        public static bool Less(IComparable first, IComparable second)
        {
            return first.CompareTo(second) < 0;
        }
    }
}
}
