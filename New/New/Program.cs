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
            int cen = int.Parse(Console.ReadLine());

            Console.Write("years: " + cen * 1000 + "\ndays: " + cen * 1000 * 365 + "\nhours: " + cen * 1000 * 365 * 24 + "\nmin: " + cen * 1000 * 365 * 24* 60);
        }
    }
}
