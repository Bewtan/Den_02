using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banker
{
    static class Bank
    {
        public static void Withdraw(List<BankAccount> accs, int id, double sum)
        {
            int count = 0;
            foreach (BankAccount a in accs)
            {
                count++;
                if (a.ID == id)
                {
                    if (sum <= a.Balance)
                        a.Withdraw(sum);
                    else
                        Console.WriteLine("Not enough funds");
                    break;
                }
                else if (a.ID != id && count == accs.Count)
                    Console.WriteLine("No such bank account");
            }
        }

        public static void Deposit(List<BankAccount> accs, int id, double sum)
        {
            int count = 0;
            foreach (BankAccount a in accs)
            {
                count++;
                if (a.ID == id)
                {
                    a.Deposit(sum); 
                    break;
                }
                else if (a.ID != id && count == accs.Count)
                    Console.WriteLine("No such bank account");
            }
        }
        public static void Print(List<BankAccount> accs, int id)
        {
            int count = 0;
            foreach (BankAccount a in accs)
            {
                count++;
                if (a.ID == id)
                {
                    Console.WriteLine(a.ToString());
                    break;
                }
                else if (a.ID != id && count == accs.Count)
                    Console.WriteLine("No such bank account");
            }
        }



    }
}
