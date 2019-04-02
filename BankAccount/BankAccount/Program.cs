using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            Person person3 = new Person();

            person1.Name = Console.ReadLine();
            person1.Age = int.Parse(Console.ReadLine());
            person2.Name = Console.ReadLine();
            person2.Age = int.Parse(Console.ReadLine());
            person3.Name = Console.ReadLine();
            person3.Age = int.Parse(Console.ReadLine());

            BankAccount new1 = new BankAccount();
            new1.ID = int.Parse(Console.ReadLine());
            new1.Balance = double.Parse(Console.ReadLine());
            BankAccount new2 = new BankAccount();
            new2.ID = int.Parse(Console.ReadLine());
            new2.Balance = double.Parse(Console.ReadLine());
            BankAccount new3 = new BankAccount();
            new3.ID = int.Parse(Console.ReadLine());
            new3.Balance = double.Parse(Console.ReadLine());
            BankAccount new4 = new BankAccount();
            new4.ID = int.Parse(Console.ReadLine());
            new4.Balance = double.Parse(Console.ReadLine());
            BankAccount new5 = new BankAccount();
            new5.ID = int.Parse(Console.ReadLine());
            new5.Balance = double.Parse(Console.ReadLine());
            BankAccount new6 = new BankAccount();
            new6.ID = int.Parse(Console.ReadLine());
            new6.Balance = double.Parse(Console.ReadLine());

            person1.Accounts.Add(new1);
            person2.Accounts.Add(new2);
            person2.Accounts.Add(new3);
            person3.Accounts.Add(new4);
            person3.Accounts.Add(new5);
            person3.Accounts.Add(new6);

            Console.WriteLine(person1.GetBalance());
            Console.WriteLine(person2.GetBalance());
            Console.WriteLine(person3.GetBalance());
        }
    }
}
