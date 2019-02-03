using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string final = "";

            while (a > 0)
            {
                if (a % 16 < 10)
                    final += a % 16;
                else
                    final += (char)(a % 16 + 55);
                a/= 16;
            }

            for (int i = final.Length - 1; i >= 0; i--)
                Console.Write(final[i]);
            
            Console.WriteLine();
        }
    }
}
