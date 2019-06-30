using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            MergeSort(arr, 0, arr.Length - 1);
            Console.WriteLine(String.Join(" ",arr));
        }

        public static void QuickSort<T>(T[] arr, int left, int right) where T : IComparable
        {
            int i = left, j = right, mid = (right + left) / 2; ;
            while(i <= j)
            {
                while (Less(i, mid))
                    i++;
                while (Less(mid + 1, j))
                    j--;

            }


        }

        public static void MergeSort<T>(T[] arr, int left, int right)where T:IComparable
        {
            if (right <= left)
                return;
            int mid = (left + right) / 2;

            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);

            T[] temp = new T[right-left+1];
            int i = left, j = mid + 1, k = 0;
            while(i <= mid && j <= right)
            {
                if (Less(arr[i], arr[j]))
                    temp[k++] = arr[i++];
                else
                    temp[k++] = arr[j++];
            }
            
            while(j <= right)
                temp[k++] = arr[j++];
            while (i <= mid)
                temp[k++] = arr[i++];
            for(int g = left;g <= right; g++)
            {
                arr[g] = temp[g - left];
            }
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

            Console.WriteLine(String.Join(" ", arr));
        }


        public static void Swap<T>(T[] arr,int first,int second)
        {
            T temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
            /*Console.WriteLine(arr[second] +"<->" +arr[first]);
            Console.WriteLine(String.Join(" ", arr));*/
        }

        public static bool Less(IComparable first,IComparable second)
        {
            return first.CompareTo(second) < 0;
        }

    }
}
