using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EinKleinesGeschaeft
{
    class Product
    {
        private string name;
        private string code;
        private double price;
        private double stock;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public double Stock
        {
            get { return stock; }
            set { stock = value; }
        }

    }
}
