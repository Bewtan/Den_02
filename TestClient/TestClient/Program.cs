using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var accounts = new Dictionary<int, BankAccount>();
            while (true)
            {
                List<string> input = Console.ReadLine().Split(' ').ToList();
                if (input[0] == "End")
                    break;
                else if(input[0] == "Create")
                else if(input[0] == "Deposit")
                    Deposit(input,accounts);
                else if(input[0] == "Withdraw")
                else if(input[0] == "Print")
                



            }

        }
    }
}
