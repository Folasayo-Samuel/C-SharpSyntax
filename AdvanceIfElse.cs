// using Internal;
using System;

namespace CSharpCrashCourse
{
	class AdvanceIfElse
	{
		static void Main(string[] args)
		{
			var getMax = GetMax(20, 10, 5);
			Console.WriteLine(getMax);

			Console.ReadLine();
		}
		
		static int GetMax(int num1, int num2, int num3)
		{
			int result;
			
			if(num1 >= num2 && num1 >= num3)
			{
				result = num1;
			} else if(num2 >= num1 && num2 >= num3)
			{
                result = num2;
            }else
			{
				result = num1;
			}
            return result;
        }
	}

}