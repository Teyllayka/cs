using System;
namespace dtm {
    public class dtm {
        
        public void first() {
          string name = "Shadow"; 
          string breed = "Golden Retriever";
          int age = 19;
          double weight = 65.22;  
          bool walk = true;
          Console.WriteLine($"{name}, {breed}, {age}, {weight}, {walk}");
        }

        public void second() {
          int userAge = int.Parse(Console.ReadLine());
      	   double jupiterYears = 11.86;
      	   double jupiterAge = userAge/jupiterYears;
      	   int journeyToJupiter = 9;
      	   int newEarthAge = userAge + journeyToJupiter;
      	   double newJupiterAge = newEarthAge/jupiterYears;
      		
      	   Console.WriteLine(jupiterAge + " " + newEarthAge + " " + newJupiterAge);
        }

        public void third() {
          int students = 18;
      		int groupSize = 4;
      		while (students % groupSize != 0 && groupSize > 2) {
      			Console.WriteLine("Unsuccessful, group size = " + groupSize);
      			groupSize--;
      		}
      		Console.WriteLine("Successful, group size = " + groupSize);
        }

        public void fourth() {
          int numberOne = 12932;
      		int numberTwo = -2828472;
      
      		double first = Math.Sqrt(numberOne);
      		double second = Math.Sqrt(numberTwo);
      		
      		Console.WriteLine(Double.IsNaN(first) ?  Double.IsNaN(second) ? "None" : numberTwo : Double.IsNaN(second) ? numberOne : Math.Min(numberOne, numberTwo)  );
        }
    }
}
