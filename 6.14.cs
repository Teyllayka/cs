using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine(Compare(Console.ReadLine(), Console.ReadLine()));
    
  }

  static bool Compare(string str1, string str2, int poz = 0) {
    if (str1.Length != str2.Length) {
      return false;
    }

    if (poz > str1.Length-1) {
      return true;
    }

    if(str1[poz] == str2[poz]) {
      return Compare(str1, str2, poz+1);
    } 
    
    return false;
  }

  
}
