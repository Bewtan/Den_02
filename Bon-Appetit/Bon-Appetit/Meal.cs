using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bon_Appetit
{
    class Meal
    {
        private string name;
        private string type;
        private List<Product> products = new List<Product>();
        private int ordered;
        private double price;
        private static List<Meal> menu = new List<Meal>();

        public string Name
        {
            get { return name; }
            set {
                if (name.Length < 3)
                    throw new ArgumentException("Meal name can't be less than 3 symbols!");
                name = value; }
        }

        public string Type
        {
            get { return type; }
            set {
                if (type == null)
                    throw new ArgumentException("Meal type can't be empty!");
                type = value; }
        }

        public int Ordered
        {
            get { return ordered; }
            set { ordered = value; }
        }
        
        public List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }
        
        public double Price
        {
            get { return price; }
            set
            {
                foreach (Product a in products)
                    price += a.Price;
                price *= 1.3;
            }
        }

        public static List<Meal> Menu
        {
            get { return menu; }
        }


        ////////////////////////////////////////////////////////////
        public Meal(string name, string type)
        {
            if (name.Length < 3)
                throw new ArgumentException("Meal name can't be less than 3 symbols!");
            if (type == null)
                throw new ArgumentException("Meal type can't be empty!");
            this.name = name;
            this.type = type;
        }

        public Meal(string name, string type,List<Product> products) 
        {
            if (name.Length < 3)
                throw new ArgumentException("Meal name can't be less than 3 symbols!");
            if (type == null)
                throw new ArgumentException("Meal type can't be empty!");
            this.name = name;
            this.type = type;
            this.products = products;
        }

        public static void AddMeal(string name, string type)
        {
            Meal a1 = new Meal(name,type);
            menu.Add(a1);
            Commands.NameToM[name] = a1;
        }

        public static void AddMealProducts(string name, string type, int count)
        {
            string[] products = Console.ReadLine().Split(' ').ToArray();
            List<Product> a1 = new List<Product>();
            foreach (string k in products)
            {
                foreach (Product a in Product.Products)
                {
                    if (a.Name == k)
                        a1.Add(a);
                }
            }
            Meal a2 = new Meal(name,type,a1);
            menu.Add(a2);
            Commands.NameToM[name] = a2;
        }

        public override string ToString()
        {
            return this.name + "-" + this.type;
        }
      


    }
}
