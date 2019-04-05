using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bon_Appetit
{
    static class Commands
    {
        private static Dictionary<string, Product> nameToP = new Dictionary<string, Product>();
        private static Dictionary<string, Meal> nameToM = new Dictionary<string, Meal>();
        
        public static Dictionary<string,Product> NameToP
        {
            get { return nameToP; }
            set {
                foreach (Product a in Product.Products)
                    nameToP[a.Name] = a;           
            }
        }

        public static Dictionary<string, Meal> NameToM
        {
            get { return nameToM; }
            set
            {
                foreach (Meal a in Meal.Menu)
                    nameToM[a.Name] = a;
            }
        }

        ///////////////////////////////////////////////////////////////////////////////
        public static void AddProductToMeal(string nameP, string nameM)
        {
            foreach (Meal a in Meal.Menu)
                if (a.Name == nameM)
                    a.Products.Add(nameToP[nameP]);
        }

        public static void ContainsProduct(string nameP, string nameM)
        {
                    if (nameToM[nameM].Products.Contains(nameToP[nameP]))
                        Console.WriteLine("{0} is contained in {1}",nameP,nameM);
                    else
                        Console.WriteLine("{0} isn't contained in {1}", nameP, nameM);
        }

        public static void GetMealPrice(string nameM)
        {
              Console.WriteLine("The price of {0} is {1:f2}",nameM,nameToM[nameM].Price);
        }

        public static void PrintMealRecipe(string nameM)
        {
            for (int i = 0; i < 25; i++)
                Console.Write('-');
            Console.WriteLine("\n{0} RECIPE",nameM);
            for (int i = 0; i < 25; i++)
                Console.Write('-');
            foreach(Product a in nameToM[nameM].Products)
                Console.WriteLine("{0}-{1}",a.Name,a.Weight);
            for (int i = 0; i < 25; i++)
                Console.Write('-');
        }

        public static void OrderMeal(string nameM)
        {
            foreach (Meal a in Meal.Menu)
                if (a.Name == nameM)
                    a.Ordered += 1;
        }

        public static void GetSpecialty()
        {
            string b = null;
            int i = 0;
            foreach (Meal a in Meal.Menu)
            {
                if(a.Ordered > i){
                    i = a.Ordered;
                    b = a.Name;
                }
            }
                
            Console.WriteLine( "The current specialty is: " + b);
        }

        public static void RecommendByPrice(double price)
        {
            List<Meal> sortedByprice = new List<Meal>();
            sortedByprice = Meal.Menu.Where(a => a.Price <= price).OrderBy(a => a.Price).ToList();
            Console.WriteLine("The recommended meal for {0} is {1}.It costs {2}",price,sortedByprice[0].Name,sortedByprice[0].Price);
        }

        public static void RecommendByPriceAndType(double price, string type)
        {
            List<Meal> sortedByprice = new List<Meal>();
            sortedByprice = Meal.Menu.Where(a => a.Price <= price && a.Type == type).OrderBy(a => a.Price).ToList();
            Console.WriteLine("The recommended meal for {0} is {1}.It costs {2}", price, sortedByprice[0].Name, sortedByprice[0].Price);
        }

        public static void GetCheapestProduct()
        {
            List<Product> sortedByprice = Product.Products.OrderByDescending(a => a.Price).ToList();
            Console.WriteLine("The cheapest product is {0}.",sortedByprice[0].Name);
        }

    }
}
