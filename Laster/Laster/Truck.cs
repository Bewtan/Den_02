using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laster
{
    class Truck
    {
        private string name;
        private int capacity;
        private List<string> cargo = new List<string>();

        public int Capacity
        {
            get { return capacity; }
            set {
                if (value < 0)
                    throw new ArgumentException("Capacity can't be negative!");
                    capacity = value; }
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

        public List<string> Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

    }
}
