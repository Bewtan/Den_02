using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputPlanets = Console.ReadLine().Split(' ').ToArray();
            string[] inputBuildings = Console.ReadLine().Split(' ').ToArray();
            string[] inputShips = Console.ReadLine().Split(' ').ToArray();

            List<Planet> planets = new List<Planet>();
            List<Building> buildings = new List<Building>();
            List<Ship> ships = new List<Ship>();

            for (int i = 0; i < inputPlanets.Count(); i += 3)
            {
                Planet a1 = new Planet();
                a1.Name = inputPlanets[i];
                a1.Metal = int.Parse(inputPlanets[i+1]);
                a1.Mineral = int.Parse(inputPlanets[i + 2]);
            }

            for (int i = 0; i < inputBuildings.Count(); i += 3)
            {
                Building a1 = new Building();
                a1.Name = inputBuildings[i];
                a1.Metal = int.Parse(inputBuildings[i + 1]);
                a1.Mineral = int.Parse(inputBuildings[i + 2]);
            }

            for (int i = 0; i < inputShips.Count(); i += 3)
            {
                Ship a1 = new Ship();
                a1.Name = inputShips[i];
                a1.Metal = int.Parse(inputShips[i + 1]);
                a1.Mineral = int.Parse(inputShips[i + 2]);
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                if (input[0] == "END")
                    break;
                foreach (Planet a in planets)
                {
                    if(a.Name == input[0])
                        

                }


            }

        }
    }
}
