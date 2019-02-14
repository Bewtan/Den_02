using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Min
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int[,] matrix = new int[a, b];

            //input
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[rows, col] = int.Parse(Console.ReadLine());
                }
            }

            //output
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[rows, col] + " ");
                }
                Console.WriteLine();
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int k = 0;
                for (int rows = 0; rows < matrix.GetLength(0); rows++)
                {
                    if (k > matrix[rows, col] || k == 0)
                        k = matrix[rows, col];
                }
                Console.Write(k + " ");
            }

        }
    }
}
