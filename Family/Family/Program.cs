using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Family
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Family fam = new Family();

            for (int i = 0; i < count; i++)
            {
                Person a1 = new Person();
                List<string> input = Console.ReadLine().Split(' ').ToList();
                 a1.Age = int.Parse(input[1]);
                 a1.Name = input[0];
                 fam.Fam.Add(a1);
             }
            
             fam.Fam.OrderBy(a => a.Name);
             foreach (Person a in fam.Fam)
             {
                 Console.WriteLine("{0} {1}",a.Name,a.Age);
             }
            
        }
    }
}
