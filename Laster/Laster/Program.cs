using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laster
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputTrucks = Console.ReadLine().Split('=', ';').ToArray();
            string[] inputCargo = Console.ReadLine().Split('=', ';').ToArray();
            List<Truck> trucks = new List<Truck>();
            List<Freight> freight = new List<Freight>();

            for (int i = 0; i < inputTrucks.Count(); i += 2)
            {
                Truck a1 = new Truck();
                a1.Name = inputTrucks[i];
                a1.Capacity = int.Parse(inputTrucks[i + 1]);
                trucks.Add(a1);
            }
            
            for (int i = 0; i < inputCargo.Count(); i += 2)
            {
                Freight a1 = new Freight();
                a1.Name = inputCargo[i];
                a1.Weight = int.Parse(inputCargo[i + 1]);
                freight.Add(a1);
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                if (input[0] == "END")
                    break;
                foreach (Freight a in freight)
                {
                    if (input[1] == a.Name)
                    {
                        foreach (Truck a1 in trucks)
                        {
                            if (input[0] == a1.Name && a1.Capacity >= a.Weight)
                            {
                                a1.Cargo.Add(a.Name);
                                Console.WriteLine("{0} loaded with {1}", a1.Name, a.Name);
                                a1.Capacity -= a.Weight;
                            }
                            else if (input[0] == a1.Name && a1.Capacity < a.Weight)
                                Console.WriteLine("{0} can't load {1}",a1.Name, a.Name);
                        }
                    }
                }
            }

            foreach (Truck a in trucks)
            {
                if(a.Cargo.Count != 0)
                    Console.WriteLine("{0}-{1}",a.Name,string.Join(", ",a.Cargo));
                else
                    Console.WriteLine("{0}- Nothing loaded", a.Name);
            }

        }
    }
}
