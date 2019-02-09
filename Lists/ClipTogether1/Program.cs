using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClipTogether1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> num = Console.ReadLine().Split('|').ToList();
            List<string> v = new List<string>();
            
            for (int i = num.Count - 1; i >= 0; i--)
            {
                string k = num[i];
                v.Add(k);
            }

            Console.WriteLine(string.Join("",v));
        }
    }
}
