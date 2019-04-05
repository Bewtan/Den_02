using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EinKleinesGeschaeft
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                if (input[0] == "Close")
                    break;
                if (input[0] == "Add")
                    Functions.Add(input[1], input[2], double.Parse(input[3]), double.Parse(input[4]));
                else if (input[0] == "Sell")
                    Functions.Sell(input[1], double.Parse(input[2]));
                else if (input[0] == "Update")
                    Functions.Update(input[1], double.Parse(input[2]));
                else if (input[0] == "PrintA")
                    Functions.PrintA();
                else if (input[0] == "PrintU")
                    Functions.PrintU();
                else if (input[0] == "PrintD")
                    Functions.PrintD();
                else if (input[0] == "Calculate")
                    Console.Write("{0:f2}", Functions.Calculate());
            }
        }
    }
}
