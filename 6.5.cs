using System;

class Program {
  public static void Main (string[] args) {
    NamePets("Laika", "Laima");
    NamePets("mango, puddy", "bucket");
    NamePets();
    
  }

  public static void NamePets(string pet1, string pet2) {
    Console.WriteLine($"Your pets {pet1} and {pet2} will be joining your voyage across space!");
  }

  public static void NamePets(string pet1, string pet2, string pet3) {
    Console.WriteLine($"Your pet {pet1} , {pet2} and {pet3} will be joining your voyage across space!");
  }

  public static void NamePets() {
    Console.WriteLine($"Aw, you have no spacefaring pets :(");
  }
}
