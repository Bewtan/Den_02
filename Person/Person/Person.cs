using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Person
{
    class Person
    {
        private int age;
        private string name;

        public string Name {
            get {return name;}
            set { name = value; }
        }

        public int Age {
            get {return age;}
            set { age = value; }
        }

        public void Introduce()
        {
            Console.WriteLine("Hello!I'm {0} and I'm {1} years old.", name, age);
        }

    }
}
