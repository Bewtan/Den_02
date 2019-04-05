using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] InputPeople = Console.ReadLine().Split(';', '=').ToArray();
            string[] InputProducts = Console.ReadLine().Split(';', '=').ToArray();
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();
            
            for (int i = 0; i < InputPeople.Length; i+=2)
            {
                Person a1 = new Person();
                a1.Name = InputPeople[i];
                a1.Money = int.Parse(InputPeople[i + 1]);
                people.Add(a1);
            }
            
            for (int i = 0; i < InputProducts.Length; i+=2)
            {
                Product a1 = new Product();
                a1.Name = InputProducts[i];
                a1.Value = int.Parse(InputProducts[i+1]);
                products.Add(a1);
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                if (input[0] == "END")
                    break;
                foreach (Product a in products){
                    if (input[1] == a.Name)
                    {
                        foreach (Person a1 in people)
                        {
                            if (a1.Name == input[0] && a1.Money >= a.Value)
                            {
                                a1.ShoppingBag.Add(input[1]);
                                a1.Money -= a.Value;
                                Console.WriteLine("{0} bought {1}",a1.Name,a.Name);
                            }
                            else if (a1.Name == input[0] && a1.Money < a.Value)
                                Console.WriteLine("{0} can't afford {1}", a1.Name, a.Name);
                        }
                    }
                }
            }

            foreach (Person a in people)                    
            {
                if (a.ShoppingBag.Count == 0)
                    Console.WriteLine("{0} - Nothing bought",a.Name);
                else
                    Console.WriteLine("{0} - {1}", a.Name,String.Join(", ",a.ShoppingBag));
            }
                    

        }
    }
}
