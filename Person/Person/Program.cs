using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();

            person1.Name = "Anya";
            person1.Age = 17;
            person1.Introduce();

            Person person2 = new Person();
            person2.Name = Console.ReadLine();
            person2.Age = int.Parse(Console.ReadLine());

            if (person1.Age > person2.Age)
                person1.Introduce();
            else
                person2.Introduce();
        }
    }
}
