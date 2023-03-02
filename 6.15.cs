using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine(Microsoft.VisualBasic.Strings.StrReverse(ToBin(150)));
    
  }

  public static string ToBin(int num) {
    if (num == 0) {
      return "";
    }

    return num % 2 + ToBin(num/2);
  }

  
}using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine(Microsoft.VisualBasic.Strings.StrReverse(ToBin(150)));
    
  }

  public static string ToBin(int num) {
    if (num == 0) {
      return "";
    }

    return num % 2 + ToBin(num/2);
  }

  
}
