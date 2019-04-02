using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle { Width = int.Parse(Console.ReadLine()), Height = int.Parse(Console.ReadLine()) };
            Rectangle rect2 = new Rectangle { Width = int.Parse(Console.ReadLine()), Height = int.Parse(Console.ReadLine()) };

            Console.WriteLine(rect1.Area(rect1,rect2));
        }
    }
}
