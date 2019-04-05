using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laster
{
    class Freight
    {
        private string name;
        private int weight;

        public int Weight
        {
            get { return weight; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Weight can't be negative!"); 
                weight = value; }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Name can't be empty!");
                name = value; }
        }


    }
}
