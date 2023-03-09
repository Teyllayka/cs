using System;

class Prece
{
  internal string nosaukums;
  internal int cena;
  internal bool ir;

  public Prece(string nosaukums, int cena, bool ir) {
    this.nosaukums = nosaukums;
    this.cena = cena;
    this.ir = ir;
  }

  public void Print() {
    Console.WriteLine($"{nosaukums}, {cena}, {ir}");
  }
    
}

class Program
{
    public static void Main(string[] args)
    {
      Prece cocacola = new Prece("cocacola", 100, true);
      cocacola.Print();
      
      
      

    }
}
