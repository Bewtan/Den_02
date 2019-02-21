using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biggest3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var k = nums.OrderByDescending(x => x);
            var b = k.Take(3);
            Console.WriteLine(String.Join(" ",b));
        }
    }
}
