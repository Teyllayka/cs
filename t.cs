using System;
					
public class Program
{
	public static void Main()
	{
		int numberOne = 12932;
		int numberTwo = -2828472;

		double first = Math.Sqrt(numberOne);
		double second = Math.Sqrt(numberTwo);
		
		Console.WriteLine(Double.IsNaN(first) ?  Double.IsNaN(second) ? "None" : numberTwo : Double.IsNaN(second) ? numberOne : Math.Min(numberOne, numberTwo)  );
		
	}
}
