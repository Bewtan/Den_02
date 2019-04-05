using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EinKleinesGeschaeft
{
    static class Functions
    {
        private static List<Product> stock = new List<Product>();

        public static void Add(string code,string name,double price,double quantity)
        {
            Product a1 = new Product();
            a1.Name = name;
            a1.Code = code;
            a1.Stock = quantity;
            a1.Price = price;
            stock.Add(a1);
        }

        public static void Sell(string code, double quantity)
        {
            int i = 0;
            foreach (Product a in stock)
            {
                i++;
                if (a.Code == code)
                {
                    if (a.Stock >= quantity)
                        a.Stock -= quantity;
                    else
                        Console.WriteLine("Not enough Quantity");
                    break;
                }
                else if(a.Code != code && stock.Count == i)
                    Console.WriteLine("No such product");
            }
        }

        public static void Update(string code, double quantity)
        {
            int i = 0;
            foreach (Product a in stock)
            {
                i++;
                if (a.Code == code)
                {
                    a.Stock += quantity;
                    break;
                }
                else if (a.Code != code && stock.Count == i)
                    Console.WriteLine("Please add your product first");
            }
        }

        public static void PrintA()
        {
            List<Product> sorted = stock.OrderBy(a => a.Name).ToList();
            foreach (Product a in sorted)
            {
                if (a.Stock != 0)                    
                    Console.WriteLine("{0} ({1})",a.Name ,a.Code);
            }  
        }

        public static void PrintU()
        {
            List<Product> sorted = stock.OrderBy(a => a.Name).ToList();
            foreach (Product a in sorted)
            {
                if (a.Stock == 0)
                    Console.WriteLine("{0} ({1})", a.Name, a.Code);
            }
        }

        public static void PrintD()
        {
            List<Product> sorted = stock.OrderBy(a => a.Stock).ToList();
            foreach (Product a in sorted)
            {
                Console.WriteLine("{0} ({1})", a.Name, a.Code);
            }
        }

        public static double Calculate()
        {
            double sum = 0;
            foreach (Product a in stock)
                sum += a.Price * a.Stock;
            return sum;
        }

    }
}
