using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListOfPersonel
{
    class Employee
    {
        private string name;
        private double salary;
        private string job;
        private string dep;
        private string email;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Job
        {
            get { return job; }
            set { job = value; }
        }
        public string Dep
        {
            get { return dep; }
            set { dep = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
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

    }
}
