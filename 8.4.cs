using System;

class Student
{
    public string Vards {get; set;}
    public int Kurss {get; set;}
    public int Numurs {get; set;}

    public Student(string Vards, int Kurss, int Numurs) {
      this.Vards = Vards;
      this.Kurss = Kurss;
      this.Numurs = Numurs;
      
    }

    public void Print() {
      Console.WriteLine($" {this.Vards} {this.Kurss} {this.Numurs} ");
    }
}

class Aspirant: Student {
  public Aspirant(string Vards, int Kurss, int Numurs) : base(Vards, Kurss, Numurs)  {
  
  }

  public void Print() {
    base.Print();
  }
}


class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    Student a1 = new Student("aaa", 1, 2);
    a1.Print();
    Aspirant a2 = new Aspirant("aaa", 1, 2);
    a2.Print();
  }
}
