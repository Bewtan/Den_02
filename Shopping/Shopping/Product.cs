using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping
{
    class Product
    {
        private string name;
        private int value;

        public string Name
        {
            get { return name; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Name can't be empty");
                name = value; }
        }

        public int Value
        {
            get { return this.value; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Money can't be negative");    
                this.value = value; }
        }

    }
}
