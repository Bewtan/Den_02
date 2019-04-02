using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordGame
{
    class Program
    {
        static void Main(string[] args)
        {
            long winner = -1;
            string winnerw = "";

            while (true)
            {
                string words = Console.ReadLine();
                if (words == "END OF GAME")
                    break;
                long score = 0;

                foreach(char a in words)
                    score += a;
                
                string words2 = words.ToUpper();

                if (words[0] == words2[0])
                    score += 15;
                if (words[words.Length - 1] == 't')
                    score += 20;
                if (words.Length-1 >= 10)
                    score += 30;
                
                if (winner <= score)
                {
                    winner = score;
                    winnerw = words;
                }
                
            }

            Console.WriteLine("Winner is word: {0}\nPoints: {1}",winnerw,winner);



        }
    }
}
