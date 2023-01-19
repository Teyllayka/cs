using System;
					
public class Program
{
	public static void Main()
	{
		int numberOne = 12932;
		int numberTwo = -2828472;
		
		Console.WriteLine(Math.Sqrt(numberOne) > Math.Sqrt(numberTwo) ? numberTwo : numberOne);
	}
}
