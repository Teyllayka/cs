using System;
					
public class Program
{
	public static void Main()
	{
		double a = double.Parse(Console.ReadLine());
		double b = double.Parse(Console.ReadLine());
		double c = double.Parse(Console.ReadLine());
		
		double d = Math.Sqrt(b*b-4*a*c);
		
		Console.WriteLine(d);
		
		if(Double.IsNaN(d) || d < 0) {
			Console.WriteLine("None");
		} else if (d == 0) {
			Console.WriteLine("X1 = " + (b*-1)/(a*2));
		} else {
			Console.WriteLine("X1 = " + (b*-1 + d)/(a*2) + " X2 = " + (b*-1 - d)/(a*2));
		}
			
	}
}
