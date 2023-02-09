using System;

class Program {
  public static void Main (string[] args) {
    int num = Convert.ToInt32(Console.ReadLine());
    for(int i = 1; i <= 10; i++) {
      for(int k = 1; k <= num; k++) {
        Console.Write($"{i}*{k} = {i*k}  ");
      }
      Console.WriteLine();
    }
    
    
  }
}
