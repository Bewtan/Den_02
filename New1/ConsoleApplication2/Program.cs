using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = 0;
            int i = 0;
            while(a > 0)
            {
                b += (int)(a % 10 * Math.Pow(2,i));
                a /= 10;
                i++;
            }
            Console.WriteLine(b);
        }
    }
}
