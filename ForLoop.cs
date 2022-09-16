// using Internal;
using System;

namespace CSharpCrashCourse
{
	class ForLoop
	{
		static void Main(string[]args)
		{
			int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
			
			for(int i = 1; i < luckyNumbers.Length; i++)
			{
				Console.WriteLine(luckyNumbers[i]);
			}
		}
	}
}