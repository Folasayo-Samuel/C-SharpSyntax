// using Internal;
using System;

namespace CSharpCrashCourse

{
	public class UserInput
{
	static void Main(string[] args)
	{
		Console.Write("Enter your name: ");
		var name = Console.ReadLine();
		Console.Write("Enter your age: ");
		var age = Console.ReadLine();
		Console.WriteLine("Hi, " + name + " you are " + age);

		Console.ReadLine();
	}
}
}
