using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bon_Appetit
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            do
            {
                command = Console.ReadLine();
                string[] commandData = command.Split(' ').ToArray();
                
                switch (commandData[0])
                {
                    case "AddProduct":
                        Product.AddProduct(commandData[1], double.Parse(commandData[2]), int.Parse(commandData[3]));
                        break;
                    case "AddMultiProducts":
                        Product.AddMultiProduct(int.Parse(commandData[1]));
                        break;
                    case "AddMeal":
                        Meal.AddMeal(commandData[1], commandData[2]);
                        break;
                    case "AddMealProducts":
                        Meal.AddMealProducts(commandData[1], commandData[2], int.Parse(commandData[3]));
                        break;
                    case "AddProductToMeal":
                        Commands.AddProductToMeal(commandData[1], commandData[2]); // <Product> <Meal>
                        break;
                    case "ContainsProduct":
                        Commands.ContainsProduct(commandData[1], commandData[2]); // <Product> <Meal>
                        break;
                    case "GetMealPrice":
                        Commands.GetMealPrice(commandData[1]);
                        break;
                    case "PrintMealRecipe":
                        Commands.PrintMealRecipe(commandData[1]);
                        break;
                    case "OrderMeal":
                        Commands.OrderMeal(commandData[1]);
                        break;
                    case "GetSpecialty":
                        Commands.GetSpecialty();
                        break;
                    case "RecommendByPrice":
                        Commands.RecommendByPrice(double.Parse(commandData[1]));
                        break;
                    case "RecommendByPriceAndType":
                        Commands.RecommendByPriceAndType(double.Parse(commandData[1]), commandData[2]);
                        break;
                    case "Cheapest":
                        Commands.GetCheapestProduct();
                        break;
                    /*case "PrintProduct":
                        Console.WriteLine(Commands.NameToP[commandData[1]].ToString(commandData[1]));
                        break;
                    case "PrintMeal":
                        Console.WriteLine(Commands.NameToM[commandData[1]].ToString(commandData[1]));
                        break;*/
                }


            } while (command != "End");
            

        }
    }
}
