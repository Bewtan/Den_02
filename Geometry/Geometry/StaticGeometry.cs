using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometry
{
     static class StaticGeometry
    {
         public static double SquareP(double side)
        {
            return side * 4;
        }
        
        public static double SquareA(double side)
        {
            return side * side;
        }

        public static double RectP(double side1, double side2)
        {
            return (side1 *2)+(side2*2);
        }

        public static double RectA(double side1, double side2)
        {
            return side1 * side2;
        }

        public static double CircleP(double radius)
        {
            return radius*2*Math.PI;
        }

        public static double CircleA(double radius)
        {
            return radius * radius * Math.PI;
        }
    }
}
