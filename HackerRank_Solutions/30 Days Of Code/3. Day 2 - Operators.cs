using System;
using System.Collections.Generic;
using System.IO;

namespace HackerRank_Solutions._30_Days_Of_Code
{
    class Solution
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            double mealCost = double.Parse(Console.ReadLine());
            int tipPercent = int.Parse(Console.ReadLine());
            int taxPercent = int.Parse(Console.ReadLine());

            double tip = mealCost * tipPercent / 100;
            double tax = mealCost * taxPercent / 100;
            double totalCost = mealCost + tip + tax;

            Console.WriteLine("The total meal cost is {0} dollars.", Math.Round(totalCost));

        }
    }
}
