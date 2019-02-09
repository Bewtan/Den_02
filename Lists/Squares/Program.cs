using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Squares
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> b = new List<int> ();

            foreach (var k in num)
                if (Math.Sqrt(k) * Math.Sqrt(k) == k)
                    b.Add(k);

            b.Sort();
            b.Reverse();

            Console.WriteLine(string.Join(" ", b));
        }
    }
}
