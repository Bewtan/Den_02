using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Debugging
{
    class Program
    {
        static int odd (int a)
        {
            int b = 0;
            while (Math.Abs(a) > 0)
            {
                if (a % 10 % 2 != 0)
                    b += a % 10;
                a /= 10;
            }
            return b;
        }
        
        static int even(int a)
        {
            int b = 0;
            while (Math.Abs(a) > 0)
            {
                if (a % 10 % 2 == 0)
                    b += a % 10;
                a /= 10;
            }
            return b;
        }
        
        static void Main(string[] args)
        {
        
          int a = int.Parse(Console.ReadLine());
            Console.WriteLine(odd(a));
            Console.WriteLine(even(a));
            Console.WriteLine(odd(a) * even(a));
        }
    }
}
