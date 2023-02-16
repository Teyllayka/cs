using System;

class Program {
  public static void Main (string[] args) {
    string text = Console.ReadLine();
    string[] words = text.Split(' ');
    foreach (var word in words) {
      if(word[0] == 'a' || word[0] == 'A') {
        Console.WriteLine(word);
      }
    }
  }
}
