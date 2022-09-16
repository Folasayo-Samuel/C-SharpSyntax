// using Internal;
using System;

namespace CSharpCrashCourse
{
	class BuildingMethod
	{
		static void Main(string[] args)
		{

			var getPow = GetPow(3, 1);
            Console.WriteLine(getPow);
            Console.ReadLine();
		}
		
		static int GetPow(int baseNum, int powNum)
		{
			int result = 1;

			for (int i = 0; i < powNum; i++)
			{
				result = result * baseNum;
			}
			return result;

		}
	}
}