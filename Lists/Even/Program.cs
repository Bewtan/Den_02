using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Even
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            num.RemoveAll(a => a % 2 == 1);

            foreach (var k in num)
                Console.Write( k + " ");
            Console.WriteLine();

        }
    }
}
