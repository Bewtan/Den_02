using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_SecondRound
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            
            int treadmill = 5899;
            int cross = 1699;
            int bike = 1789;
            int dumbells = 579;

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string type = Console.ReadLine();

                if (type == "treadmill")
                    total += treadmill;
                if (type == "cross trainer")
                    total += cross;
                if (type == "exercise bike")
                    total += bike;
                if (type == "dumbbells")
                    total += dumbells;
            }
            Console.WriteLine("{0:f2}",total);
        }
    }
}
