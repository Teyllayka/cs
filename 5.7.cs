using System;


class Program {
  public static void Main (string[] args) {
    string password = Console.ReadLine();
    int passwordLength = password.Length;
    bool passwordCheck = password.Contains('!');

    Console.WriteLine($"user password is {password}  its length is {passwordLength} char and receives a {passwordCheck} check");
    
  }
}
