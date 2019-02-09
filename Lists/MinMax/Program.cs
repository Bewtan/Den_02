using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            num.Sort();

            for (int i = 0; i < num.Count; i++)
                if (num[i] == num[num.Count - 1] || num[i] == num[0])
                    Console.Write(num[i] + " ");

        }
    }
}
