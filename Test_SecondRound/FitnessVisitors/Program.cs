using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FitnessVisitors
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> visitors = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                    break;
 
                else if (input == "Add visitor")
                    visitors.Add(Console.ReadLine());
                else if (input == "Remove first visitor")
                    visitors.RemoveAt(0);
                else if (input == "Remove last visitor")
                    visitors.RemoveAt(visitors.Count - 1);
                else if (input == "Remove visitor on position")
                    visitors.RemoveAt(int.Parse(Console.ReadLine()));
                else if (input == "Add visitor on position")
                {
                    string name = Console.ReadLine();
                    visitors.Insert(int.Parse(Console.ReadLine()), name);
                }
                else
                    visitors = input.Split(',').ToList();
            }

            Console.WriteLine(string.Join(",",visitors));

        }
    }
}
