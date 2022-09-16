// using Internal;
// using Internal;
using System;

namespace CSharpCrashCourse

{
	class CSharpException
	{
		static void Main(string[] args)
		{
			try
			{
				Console.Write("Enter a number: ");
				int num1 = Convert.ToInt32(Console.ReadLine());
				
			Console.Write("Enter another number: ");
			int num2 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine(num1 / num2);

			Console.ReadLine();
			}
			catch (Exception e)
			{
				
				Console.WriteLine(e.Message);
			}catch(FormatException e)
			{
				Console.WriteLine(e.Message);
			}
			// finally {
				
			//  }
		}
	}
}