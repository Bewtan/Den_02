using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            bool j = true;
            List<string> values = new List<string>();

            while (j)
            {
                string[] g = Console.ReadLine().Split(' ');
                foreach (string a in g)
                        values.Add(a);
                if (values.Contains("stocked"))
                    break;
            }
            
            for (int a = 0; a < values.Count; a += 3)
            {
                if (values.Count(b => b == values[a]) > 1)
                {
                   for (int k = 0; k < values.Count; k += 3){
                       if (values[k] == values[a] && k != a)
                           values[k + 2] = (int.Parse(values[a + 2]) + int.Parse(values[k + 2])).ToString();
                       }
                    values.RemoveAt(a+2);
                    values.RemoveAt(a+1);
                    values.RemoveAt(a);
                }
            }
            
            
            double jj = 0;

            for (int a = 0; a < values.Count; a += 3)
            {
                if (values[a] == "stocked")
                    break;
                Console.WriteLine("{0}: ${1} * {2} = ${3:f2}", values[a], values[a + 1], values[a + 2], (double.Parse(values[a + 1]) * int.Parse(values[a + 2])));

                jj += double.Parse(values[a + 1]) * int.Parse(values[a + 2]);
            }
            
            Console.WriteLine("-----------------\nGrand Total: ${0:f2}",jj);
        }
    }
}
