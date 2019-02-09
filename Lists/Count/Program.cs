using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Count
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> check = new List<int>();
            List<string> output = new List<string>();

            foreach (var k in num)
            {
                if (check.Contains(k))
                    check.Count();
                else
                {
                    string gg = k + "->" + num.Count(a => a == k);
                    output.Add(gg);
                }
                    check.Add(k);
            }

            output.Sort();
            Console.WriteLine(string.Join("\n",output));

        }
    }
}
