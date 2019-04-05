using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Raise
{
    class Person
    {
        private string name;
        private int age;
        private double salary;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public double Raise(double bonus)
        {
            if(this.age < 30)
                this.salary *= ((100 + (bonus/2)) / 100);
            else
                this.salary *= ((100+bonus) / 100);
            return this.salary;
        }

    }
}
