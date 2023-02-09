using System;

class Program {
  public static void Main (string[] args) {
    int emails = 20;
    for(; emails >0; emails--) {
      Console.WriteLine ($"one email deleted, {emails} left");
    }
    Console.WriteLine ("INBOX ZERO ACHIVIED!");
  }
}
