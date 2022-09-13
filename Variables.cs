using System;

namespace CSharpCrashCourse
{
	class Variables
	{
		static void Main(string[] args)
		{
			var characterName = "Indorama";
			var characterAge = 25;
			Console.WriteLine("There once was a man named " + characterName);
			Console.WriteLine("He was " + characterAge + " years old");
			Console.WriteLine($"He really liked the name " + characterName);
			Console.WriteLine("But didn't like being " + characterAge);
			
		}
	}
}