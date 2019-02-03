using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int g = 0;
            int c = 0;
            for (int i = a.Length - 1; i >= 0; i--)
            {
                var k = a[i] - 48;
                
                if (k == 17)
                    k = 10;
                else if (k == 18)
                    k = 11;
                else if (k == 19)
                    k = 12;
                else if (k == 20)
                    k = 13;
                else if (k == 21)
                    k = 14;
                else if (k == 22)
                    k = 15;

                c += (int)(k * Math.Pow(16,g));
                g++;
            }
            Console.WriteLine(c);

        }
    }
}
