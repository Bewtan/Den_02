using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping
{
    class Person
    {
        private string name;
        private int money;
        private List<string> shoppingBag = new List<string>();
        
        public string Name
        {
            get { return name; }
            set {
                if (value == null)
                    throw new ArgumentException("Name can't be empty");
                name = value; }
        }

        public int Money
        {
            get { return money; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Money can't be negative");   
                money = value; }
        }

        public List<string> ShoppingBag
        {
            get { return this.shoppingBag; }
            set { this.shoppingBag = value; }
        }

    }
}
