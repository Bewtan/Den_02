using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumMinMaxAver
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int[] nums = new int[a];

            for(int i = 0;i< a;i++)
                nums[i] = int.Parse(Console.ReadLine());
            Console.WriteLine(nums.Sum());
            Console.WriteLine(nums.Min());
            Console.WriteLine(nums.Max());
            Console.WriteLine(nums.Average());
        }
    }
}
