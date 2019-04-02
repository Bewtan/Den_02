using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rectangle
{
    class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int Area(Rectangle A,Rectangle B)
        {
            int a = (A.Width * A.Height) - (B.Width * B.Height);
            return a;
        }



    }
}
