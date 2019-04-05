using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Figure:\n->Square\n->Rectangle\n->Circle");
            string input = Console.ReadLine();

            if (input == "Square")
            {
                Console.Write("Choose Length of sides:");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Parameter or Area?");
                string PorA = Console.ReadLine();
                if (PorA == "Parameter")
                    Console.WriteLine("{0:f2}cm", StaticGeometry.SquareP(a));
                else if (PorA == "Area")
                    Console.WriteLine("{0:f2}cm", StaticGeometry.SquareA(a));
            }
            else if (input == "Rectangle")
            {
                Console.Write("Choose Length of sides:");
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Parameter or Area?");
                string PorA = Console.ReadLine();
                if (PorA == "Parameter")
                    Console.WriteLine("{0:f2}cm", StaticGeometry.RectP(a, b));
                else if (PorA == "Area")
                    Console.WriteLine("{0:f2}cm", StaticGeometry.RectA(a, b));
            }
            else if (input == "Circle")
            {
                Console.Write("Choose Length of diameter:");
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine("Parameter or Area?");
                string PorA = Console.ReadLine();
                if (PorA == "Parameter")
                    Console.WriteLine("{0:f2cm}",StaticGeometry.CircleP(r));
                else if (PorA == "Area")
                    Console.WriteLine("{0:f2cm}", StaticGeometry.CircleA(r));
            }



        }
    }
}
