using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArgumentException2
{
    class Person
    {
        private string name1;
        private string name2;
        private int age;
        private double salary;

        public string Name1
        {
            get { return name1; }
            set {
                if (value.Length < 3)
                    throw new ArgumentException("First Name can't be less than 3 symbols");
                    name1 = value; 
            }
        }
        
        public string Name2
        {
            get { return name2; }
            set
            {
                if (value.Length < 3)
                    throw new ArgumentException("Last Name can't be less than 3 symbols");    
                name2 = value;
            }
        }
        
        public int Age
        {
            get { return age; }
            set { 
                if(value <= 0)
                    throw new ArgumentException("Age cannot be 0 or less");
                age = value; }
        }

        public double Salary
        {
            get { return salary; }
            set {
                if (value <= 460)
                    throw new ArgumentException("Salary cannot be less than 460 leva");
                salary = value; }
        }

    }
}
