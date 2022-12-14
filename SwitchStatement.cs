// using Internal;
using System;

namespace CSharpCrashCourse
{
	class SwitchStatement
	{
		static void Main(string[] args)
		{
			var getDay = GetDay(100);
            Console.WriteLine(getDay);
        }
		
		static string GetDay(int dayNum)
		{
			string dayName;
			
			switch(dayNum)
			{
				case 0:
					dayName = "Sunday";
					break;
				case 1:
					dayName = "Monday";
					break;
				case 2:
					dayName = "Tuesday";
					break;
				case 3:
					dayName = "Wednesday";
					break;
				case 4:
					dayName = "Thursday";
					break;
				case 5:
					dayName = "Friday";
					break;
				case 6:
					dayName = "Saturday";
					break;
				default:
					dayName = "Invalid Day Number!";
					break;
			}

			return dayName;
		}
	}
}