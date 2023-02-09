using System;

class Program {
  public static void Main (string[] args) {
    string num = Console.ReadLine();
    int sum = 0;
    if (Convert.ToInt32(num) < 100) {
      Console.WriteLine("less than 100");
    } else {
      foreach(int i in (num)) {
        sum += i - '0';
      }
      Console.WriteLine(sum);
    }
    
  }
}
