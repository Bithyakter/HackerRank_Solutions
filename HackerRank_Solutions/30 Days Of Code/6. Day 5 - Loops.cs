using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Solutions._30_Days_Of_Code
{

    class Solution
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }

            //Another Solution
            //var N = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("{0} x {1} = {2}", N, i, N * i);
            //}
        }
    }
}
