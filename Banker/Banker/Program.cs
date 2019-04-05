using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> accs = new List<BankAccount>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                if (input[0] == "Close")
                    break;
                else if (input[0] == "Add")
                {
                    BankAccount a1 = new BankAccount();
                    a1.ID = int.Parse(input[1]);
                    a1.Balance = double.Parse(input[2]);
                    accs.Add(a1);
                }
                else if (input[0] == "Deposit")
                    Bank.Deposit(accs,int.Parse(input[1]),double.Parse(input[2]));
                else if (input[0] == "Withdraw")
                    Bank.Withdraw(accs, int.Parse(input[1]), double.Parse(input[2]));
                else if (input[0] == "Print")
                    Bank.Print(accs, int.Parse(input[1]));
            }
        }
    }
}
