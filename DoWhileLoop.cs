// using Internal;
using System;

namespace CSharpCrashCourse
{
	class DoWhileLoop
	{
		static void Main(string[] args)
		{
			var index = 8;
            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5);
        }
	}
}