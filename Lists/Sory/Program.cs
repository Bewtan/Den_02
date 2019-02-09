using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            num.Sort();

            Console.WriteLine(string.Join("<=",num));
        }
    }
}
