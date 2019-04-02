using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DaysInbetween
{
    class Program
    {
        static void Main(string[] args)
        {
            DataModifier n = new DataModifier();
            n.Date1 = Console.ReadLine();
            n.Date2 = Console.ReadLine();

            Console.WriteLine(n.Diff());
        }
    }
}
