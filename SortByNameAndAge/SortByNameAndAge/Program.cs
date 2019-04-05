using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortByNameAndAge
{
    class Program
    {
        static void Main(string[] args)         //Actually Box not SortByWhatever
        {
            Box box1 = new Box();
            box1.A = double.Parse(Console.ReadLine());
            box1.B = double.Parse(Console.ReadLine());
            box1.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Surface Area- {0:f2}\nLateral Surface Area- {1:f2}\nVolume- {2:f2}",box1.Surface() ,box1.LatSurface(),box1.Vol());
        }
    }
}
