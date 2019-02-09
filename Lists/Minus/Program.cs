using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minus
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            num.RemoveAll(a => a < 0);


            Console.WriteLine(String.Join(" ", num));
        }
    }
}
