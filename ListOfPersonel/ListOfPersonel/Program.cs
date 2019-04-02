using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListOfPersonel
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Employee> emps = new List<Employee>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                Employee a1 = new Employee();

                a1.Name = input[0];
                a1.Salary = double.Parse(input[1]);
                a1.Job = input[2];
                a1.Dep = input[3];

                if (input.Length > 4)
                {
                    if (input[4].Contains('@'))
                    {
                        a1.Email = input[4];
                        if(input.Length > 5)
                            a1.Age = int.Parse(input[5]);
                    }
                    else
                        a1.Age = int.Parse(input[4]);
                }
                emps.Add(a1);
            }

            Dictionary<string, double> salbydep = new Dictionary<string, double>();
            Dictionary<string, int> average = new Dictionary<string, int>();

            foreach (Employee a in emps)
            {
                if (salbydep.Keys.Contains(a.Dep))
                {
                    salbydep[a.Dep] += a.Salary;
                    average[a.Dep]++;
                }
                else
                {
                    salbydep[a.Dep] = a.Salary;
                    average[a.Dep] = 1;
                }
            }

            foreach (var a in average)
            {
                salbydep[a.Key] = salbydep[a.Key] / a.Value;
            }

            salbydep.OrderBy(a => a.Value);

            string dep = null;
            foreach (var a in salbydep)
            {
                Console.WriteLine("Highest Average Salary:{0}",a.Key);
                dep = a.Key;
                break;
            }

            emps.OrderBy(a => a.Salary);

            foreach (Employee a in emps)
            {
                if (a.Dep == dep)
                {
                    Console.Write("{0} {1:f2} ",a.Name,a.Salary);
                    if (a.Email != null)
                        Console.Write("{0} ", a.Email);
                    else
                        Console.Write("n/a ");
                    if (a.Age != 0)
                        Console.WriteLine("{0}", a.Age);
                    else
                        Console.WriteLine("-1");
                }
            }

        }
    }
}
