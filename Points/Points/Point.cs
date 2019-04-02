using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Points
{
    class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public double Distance (Point a)
        {
            double dist = Math.Sqrt((a.x - a.y) * (a.x - a.y) + (a.y - a.x) * (a.y - a.x));
            return dist;
        }

    }
}
