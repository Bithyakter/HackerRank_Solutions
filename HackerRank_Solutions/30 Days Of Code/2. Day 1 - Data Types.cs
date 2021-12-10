using System;
using System.Collections.Generic;
using System.IO;

namespace HackerRank_Solutions._30_Days_Of_Code
{
	class Solution
	{
		static void Main(String[] args)
		{
			// Pre-initialised variables
			int i = 4;
			double d = 4.0;
			string s = "HackerRank ";

			// Declare second integer, double, and String variables.
			int num1;
			double num2;
			string s2;

			// Read and save an integer, double, and String to your variables.
			num1 = int.Parse(Console.ReadLine());
			num2 = double.Parse(Console.ReadLine());
			s2 = Console.ReadLine();

			// Print the sum of both integer variables on a new line.
			Console.WriteLine(i + num1);

			// Print the sum of the double variables on a new line. With Format -> F1
			Console.WriteLine("{0:F1}", d + num2);

			// Concatenate and print the String variables on a new line
			// The 's' variable above should be printed first.
			Console.WriteLine("{0}{1}", s, s2);
		}
	}
}
