using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Long
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int k = 1;
            int b = 1;
            int c = 0;

            for (int i = 0; i < num.Count - 1; i++)
            {
                if (num[i] == num[i + 1])
                {
                    k++;
                    if (k > b)
                    {
                        c = i;
                        b= k;
                    }
                }
                else k = 1;
            }

            for (int i = 1; i <= b; i++)
                Console.Write(num[c] + " ");
            Console.WriteLine();


        }
    }
}
