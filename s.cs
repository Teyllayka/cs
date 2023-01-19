using System;
					
public class Program
{
	public static void Main()
	{
		int students = 18;
		int groupSize = 5;
		while (students % groupSize != 0) {
			Console.WriteLine("Unsuccessful, group size = " + groupSize);
			groupSize--;
		}
		Console.WriteLine("Successful, group size = " + groupSize);
	}
}
