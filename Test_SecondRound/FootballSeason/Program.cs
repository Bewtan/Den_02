using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballSeason
{
    class Program
    {
        static void Main(string[] args)
        {
            var players = new SortedDictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End of season")
                    break;
                string[] arr = input.Split('-').ToArray();

                if(players.Keys.Contains(arr[0]))
                    players[arr[0]] += int.Parse(arr[1]);
                else
                    players[arr[0]] = int.Parse(arr[1]);
            }

            foreach (var a in players)
                Console.WriteLine("{0}-> {1}",a.Key,a.Value);

        }
    }
}
