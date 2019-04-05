using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Root
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(RootOf.Formula(num));
            }

        }
    }
}
