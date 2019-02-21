using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string[] a1 = a.Split(' ');

            var count = new Dictionary<string, int>();
            foreach (string word in a1)
            {
                if (count.ContainsKey(word.ToLower()))
                    count[word]++;
                else count[word] = 1;
            }

            var result = new List<string>();
            foreach (var value in count)
                if (value.Value % 2 == 1)
                    result.Add(value.Key.ToLower());
            Console.WriteLine(string.Join(", ", result));

        }
    }
}
