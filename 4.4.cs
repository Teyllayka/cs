using System;

class Program {
  public static void Main (string[] args) {
    int num1 = Convert.ToInt32(Console.ReadLine());
    int num2 = Convert.ToInt32(Console.ReadLine());
    if (num1 < num2) {
      for(int i = num1; i < num2; i++) {
        if(i % 10 == 3) {
          Console.WriteLine(i);
        }
      }
    } else {
      for(int i = num1; i > num2; i--) {
        if(i % 10 == 3) {
          Console.WriteLine(i);
        }
      }
    }
    
    
  }
}
