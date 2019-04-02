using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Engine> engs = new List<Engine>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                Engine a1 = new Engine();
                a1.Model = input[0];
                a1.Power = int.Parse(input[1]);

                if (input.Length > 2)
                {
                    if (input[2] == int.Parse(input[2]).ToString())
                        a1.Efficiency = input[2];
                    else
                    {
                        a1.Displacement = int.Parse(input[2]);
                        if (input.Length > 3)
                            a1.Efficiency = input[3];
                    }
                }
                
                engs.Add(a1);
            }

            int count1 = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < count1; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                Car a1 = new Car();

                a1.Model = input[0];
                foreach (var a in engs)
                {
                    if (input[1] == a.Model)
                        a1.Engine = a;
                }

                if (input.Length > 2)
                {
                    if (input[2] == int.Parse(input[2]).ToString())
                        a1.Color = input[2];
                    else
                    {
                        a1.Weight = int.Parse(input[2]);
                        if (input.Length > 3)
                            a1.Color = input[3];
                    }
                }
                cars.Add(a1);
            }

            foreach (Car a in cars)
            {
                Console.WriteLine(a.Model + ":");
                Console.WriteLine("  " +a.Engine.Model + ":");
                Console.WriteLine("     Power: " + a.Engine.Power);
                if (a.Engine.Displacement != 0) 
                    Console.WriteLine("     Displacement: " + a.Engine.Displacement);
                else
                    Console.WriteLine("     Displacement: n/a");
                if (a.Engine.Efficiency != null)
                    Console.WriteLine("     Efficiency: " + a.Engine.Efficiency);
                else
                    Console.WriteLine("     Efficiency: n/a");
                if (a.Weight != 0)
                    Console.WriteLine("  Weight: " + a.Weight);
                else
                    Console.WriteLine("  Weight: n/a");
                if (a.Color != null)
                    Console.WriteLine("  Color: " + a.Color);
                else
                    Console.WriteLine("  Color: n/a");
            }





        }
    }
}
