using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArgumentException2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                Person a1 = new Person();
                a1.Name1 = input[0];
                a1.Name2 = input[1];
                a1.Age = int.Parse(input[2]);
                a1.Salary = double.Parse(input[3]);
                people.Add(a1);
            }
            
            people.ForEach(a => Console.WriteLine("{0} {1} gets {2:f2} leva", a.Name1,a.Name2 ,a.Salary));



        }
    }
}
