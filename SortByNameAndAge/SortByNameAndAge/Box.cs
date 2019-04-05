using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortByNameAndAge
{
    class Box
    {
        private double a;
        private double b;
        private double c;

        public double A
        {
            get { return a; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Dimensions can't be 0 or less");     
                a = value; }
        }
        public double B
        {
            get { return b; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Dimensions can't be 0 or less");  
                b = value; }
        }
        public double C
        {
            get { return c; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Dimensions can't be 0 or less");  
                c = value; }
        }

        public double Surface()
        {
            double sur =(double)(2 * a * c + 2 * a * b + 2 * b * c);
            return sur;
        }

        public double Vol()
        {
            double sur = (double)(a*b*c);
            return sur;
        }
        public double LatSurface()
        {
            double sur = (double)(2 * a * c + 2 * b * c);
            return sur;
        }


    }
}
