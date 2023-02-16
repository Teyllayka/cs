using System;

using System.Text.RegularExpressions;
class Program
{
    public static void Main(string[] args)
    {
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
