using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int[,] matrix = new int[a, b];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                var line = Console.ReadLine().Split(' ');
                int c = 0;
                foreach (var i in line)
                    matrix[rows, c++] = int.Parse(i);
            }
            

            int diag1 = 0;
            int diag2 = 0;
            int up = 0;
            int down = 0;
            int diag1even = 0;
            int outeven = 0;
            int outuneven = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (rows == col)
                    {
                        diag1 += matrix[rows, col];
                        if (matrix[rows, col] % 2 == 0)
                            diag1even += matrix[rows, col];
                    }
                     if (rows + col == b +1)
                         diag2 += matrix[rows, col];
                    if(rows < col)
                        up += matrix[rows, col];
                    if (rows > col)
                        down += matrix[rows, col];
                    if((rows == 0 || rows == matrix.GetLength(0)-1) && matrix[rows,col]%2 == 0)
                        outeven += matrix[rows,col];
                    if ((col == 0 || col == matrix.GetLength(1) - 1) && matrix[rows, col] % 2 != 0)
                        outuneven += matrix[rows, col];
                }
            }
            if (diag1 == diag2 || down % 2 != 0 || up % 2 == 0)
                Console.WriteLine("Yes\nThe amount of money won is:{0:f2}", (down + diag1even + outeven + outuneven) / 4);
            else
                Console.WriteLine("No");
        }
    }
}
