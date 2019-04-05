using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bon_Appetit
{
    class Product
    {
        private string name;
        private double price;
        private int weight;
        private static List<Product> products = new List<Product>();
        
        public static List<Product> Products
        {
            get { return products; }
        }

        public string Name
        {
            get { return name; }
            set {
                if (name.Length < 3)
                    throw new ArgumentException("Product name can't be less than 3 symbols!");
                name = value; }
        }

        public double Price
        {
            get { return price; }
            set {
                if (price < 0.01)
                    throw new ArgumentException("Product price can't be less than 0,01!");
                price = value; }
        }

        public int Weight
        {
            get { return weight; }
            set {
                if (weight <= 0)
                    throw new ArgumentException("Product weight can't be less than or equal to 0!");
                weight = value; }
        }
        ////////////////////////////////////////////////////////////////


        public Product(string name, double price, int weight)
        {
            if (price < 0.01)
                throw new ArgumentException("Product price can't be less than 0,01!");
            if (name.Length < 3)
                throw new ArgumentException("Product name can't be less than 3 symbols!");
            if (weight <= 0)
                throw new ArgumentException("Product weight can't be less than or equal to 0!");

            this.name = name;
            this.price = price;
            this.weight = weight;
        }

        public static void AddProduct(string name, double price, int weight)
        {           
            Product a1 = new Product(name,price,weight);
            products.Add(a1);
        }

        public static void AddMultiProduct(int count)
        {
             for(int i = 0;i<count;i++){
                 string[] input = Console.ReadLine().Split(' ').ToArray();
                 AddProduct(input[0],double.Parse(input[1]),int.Parse(input[2]));
                 }
        }

        /*public override string  ToString(string name)
        {
 	            return this.name + "-" + this.weight;
        }*/
      

    }
}
