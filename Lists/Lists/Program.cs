using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> kk = new List<int>();

            kk.Add(7);
            kk.Add(8);
            kk.Add(9);

            foreach (var num in kk)
                Console.Write(num);
            kk.Remove(8);
            kk.RemoveAt(1);
            kk.Add(6);
            kk.Insert(0, 90);
            Console.WriteLine();
            foreach (var num in kk)
                Console.Write(num);
            Console.WriteLine();

        }
    }
}
