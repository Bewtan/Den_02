using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Raise
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
                a1.Name = input[0] + " " + input[1];
                a1.Age = int.Parse(input[2]);
                a1.Salary = double.Parse(input[3]);
                people.Add(a1);
             }
            double Bonus = double.Parse(Console.ReadLine());
            people.ForEach(a => Console.WriteLine("{0} get {1:f2} leva",a.Name ,a.Raise(Bonus)));

        }
    }
}
