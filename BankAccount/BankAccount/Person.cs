using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccount
{
    class Person
    {
        private string name;
        private int age;
        private List<BankAccount> accounts = new List<BankAccount>();

        public string Name {
            get { return name; }
            set { name = value; }
        }

       public int Age {
            get { return age; }
            set { age = value; }
        }

       public List<BankAccount> Accounts
       {
           get { return accounts; }
           set { accounts = value; }
       }

       public double GetBalance()
       {
           return accounts.Sum(a => a.Balance);
       }

    }
}
