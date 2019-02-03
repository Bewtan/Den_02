using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace New1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string final = "";
            while (a > 0)
            {
                    final += a % 2;
                    a /= 2;
            }


            for (int i = final.Length - 1; i >= 0; i--)
                Console.Write(final[i]);

            Console.WriteLine();




        }
    }
}
