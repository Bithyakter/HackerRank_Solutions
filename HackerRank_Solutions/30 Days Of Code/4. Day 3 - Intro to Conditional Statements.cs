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
            var N = int.Parse(Console.ReadLine());

            if (N % 2 != 0)
            {
                Console.WriteLine("Weird");
            }
            else
            {
                if (N <= 5)
                {
                    Console.WriteLine("Not Weird");
                }

                else if (N <= 20)
                {
                    Console.WriteLine("Weird");
                }

                else
                {
                    Console.WriteLine("Not Weird");
                }
            }

            //ANOTHER SOLUTION
            int N = Convert.ToInt32(Console.ReadLine());
            
            if (N % 2 == 1)
                Console.WriteLine("Weird");

            else if (N % 2 == 0 && N >= 2 && N <= 5)
                Console.WriteLine("Not Weird");

            else if (N % 2 == 0 && N >= 6 && N <= 20)
                Console.WriteLine("Weird");

            else if (N % 2 == 0 && N >= 20)
                Console.WriteLine("Not Weird");
        }
    }
}
