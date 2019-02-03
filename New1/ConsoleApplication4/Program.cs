using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string c = "";
            string b = "";

            for (int i = a.Length - 1; i >= 0; i--)
            {
                var k = a[i];

                if (k == 49)
                    c = "0001";
                else if (k == 50)
                    c = "0010";
                else if (k == 51)
                    c = "0011";
                else if (k == 52)
                    c = "0100";
                else if (k == 53)
                    c = "0101";
                else if (k == 54)
                    c = "0110";
                else if (k == 55)
                    c = "0111";
                else if (k == 56)
                    c = "1000";
                else if (k == 57)
                    c = "1001";
                else if (k == 65)
                    c = "1010";
                else if (k == 66)
                    c = "1011";
                else if (k == 67)
                    c = "1100";
                else if (k == 68)
                    c = "1101";
                else if (k == 69)
                    c = "1110";
                else if (k == 70)
                    c = "1111";

                b += c;
            }
            
            int h = int.Parse(b);
            Console.WriteLine(h);



        }
    }
}
