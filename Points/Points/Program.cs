using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Points
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point{x = 7,y = 8};

            Console.WriteLine("{0}{1}",A.x,A.y);

            Console.WriteLine("Distance is {0}",A.Distance(A));
        }
    }
}
