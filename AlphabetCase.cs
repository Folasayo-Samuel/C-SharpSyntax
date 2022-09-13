// using Internal;
// using System.Data;
// using Internal
using System;

namespace AlphabetCase
{
	class Program
	{
		static void Main(string[] args)
		
		{
			var phrase = "Saint blogging website";
		Console.WriteLine(phrase.Contains("Blog"));
            Console.WriteLine(phrase.Substring(phrase.IndexOf("blogging")));

            Console.ReadLine();
		}
	}
}