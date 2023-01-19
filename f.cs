using System;

public class HelloWorld
{
    public static void Main()
    {
       int userAge = int.Parse(Console.ReadLine());
	   double jupiterYears = 11.86;
	   double jupiterAge = userAge/jupiterYears;
	   int journeyToJupiter = 9;
	   int newEarthAge = userAge + journeyToJupiter;
	   double newJupiterAge = newEarthAge/jupiterYears;
		
	   Console.WriteLine(jupiterAge + " " + newEarthAge + " " + newJupiterAge);
		
		
        
        
    }
}
