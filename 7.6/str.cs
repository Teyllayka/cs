using System;
using System.Text.RegularExpressions;
namespace str {
    public class str {

      public void first() {
        string text = Console.ReadLine();
        string[] words = text.Split(' ');
        foreach (var word in words) {
          if(word[0] == 'a' || word[0] == 'A') {
            Console.WriteLine(word);
          }
        }
      }

      public void second() {
         string password = Console.ReadLine();
          int passwordLength = password.Length;
          bool passwordCheck = password.Contains('!');
      
          Console.WriteLine($"user password is {password}  its length is {passwordLength} char and receives a {passwordCheck} check");
      }

      public void third() {
            string script = "Close on a portrait of the HANDSOME PRINCE -- as the BEAST`S giant paw slashes it";
        Console.WriteLine(script.Substring(0, script.IndexOf('n')+1).ToUpper() + script.Substring(script.IndexOf('n')+1).ToLower());
      }

      public void fourth() {
        int sum = 0;
        string text = Console.ReadLine();
        foreach (char i in text)
        {
            if (Char.IsPunctuation(i))
            {
                sum++;

            }
        }
         
        Console.WriteLine(sum);
      sum = 0;
        char[] text2 = Console.ReadLine().ToCharArray();
        foreach(char c in text2) {
          if (Char.IsPunctuation(c))
            {
                sum++;

            }
        }
      Console.WriteLine(sum);


      string text1 = Console.ReadLine();
      string result = Regex.Replace(text1, @"[^\w\s]", "");
      Console.WriteLine(text1.Length - result.Length);
      }
    }
  }
