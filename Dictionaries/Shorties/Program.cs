using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shorties
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().ToLower().Split(' ');

            Console.WriteLine(string.Join(" ",a.Where(k => k.Length < 5).Distinct()));
        }
    }
}
