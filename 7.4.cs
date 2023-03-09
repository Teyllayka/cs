using System;

class Student
{
    public string Vards;
    public string Kurss;
    public bool Stipendija;

    public Student(string Vards) {
      this.Vards = Vards;
      this.Kurss = "?";
      this.Stipendija = false;
      
    }

    public Student(string Vards, string Kurss) {
      this.Vards = Vards;
      this.Kurss = Kurss;
      this.Stipendija = false;
      
    }

    public Student(string Vards, string Kurss, bool Stipendija) {
      this.Vards = Vards;
      this.Kurss = Kurss;
      this.Stipendija = Stipendija;
      
    }

    public void Print() {
      Console.WriteLine($"{Vards}, {Kurss}, {Stipendija}");
    }
}

class Program
{
    public static void Main(string[] args)
    {

      Student a1 = new Student("a");
      Student a2 = new Student("b", "dp2-2");
      Student a3 = new Student("c", "dp2-2", true);

      a1.Print();
      a2.Print();
      a3.Print();
      
      

    }
}
