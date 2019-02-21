using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Miners
{
    class Program
    {
        static void Main(string[] args)
        {
            bool j = true;
            List<string> values = new List<string>();
            
            while (j)
            {
                values.Add(Console.ReadLine());
                if (values.Contains("stop"))
                    break;
            }
           
            var dict = new Dictionary<string, int>();
           
            for(int a = 0;a < values.Count;a+= 2){
                    if (values[a] != "stop")
                        if (dict.ContainsKey(values[a]))
                            dict[values[a]] += int.Parse(values[a+1]);
                        else
                            dict[values[a]] = int.Parse(values[a + 1]);
                        }
            foreach(var a in dict)
                Console.WriteLine("{0}-->{1}",a.Key,a.Value);
        
        }
    }
}
