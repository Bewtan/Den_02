using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephone
{
    class Program
    {
        static void Main(string[] args)
        {
            bool j = true;
            List<string> values = new List<string>();
            var dict = new Dictionary<string, int>();

            while (j)
            {
                string[] g = Console.ReadLine().Split(' ');
                foreach (string a in g)
                    values.Add(a);
                if (values.Contains("END"))
                {
                    for (int a = 0; a < values.Count; a++)
                        if (values[a] == "A")
                            dict[values[a + 1]] = int.Parse(values[a + 2]);
                        else if (values[a] == "S")
                            if (dict.ContainsKey(values[a+1]))
                                Console.WriteLine("{0}-->{1}",values[a+1],dict[values[a + 1]]);
                            else
                                Console.WriteLine("No such person.");
                    break;
                }
            }
            

        }
    }
}
