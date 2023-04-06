using System;

class Book
{
    public string  Name {get; set;}
    public double Cena {get; set;}
    public String Author {get; set;}

    public Book(string Name, double cena, string Author) {
      this.Author = Author;
      this.Cena = cena;
      this.Name = Name;
      
    }

    public void Print() {
      Console.WriteLine($" {this.Author} {this.Cena} {this.Name} ");
    }
}

class BookGenre: Book {
  private string Genre {get; set;}
  public BookGenre(string Name, double Cena, string Author, string Genre) : base(Name, Cena, Author)  {
  this.Genre = Genre;
  }

  public new void Print() {
    base.Print();
    Console.WriteLine(this.Genre);
    
  }
}

class BookGenrePub: BookGenre {
  private string Pub {get; set;}
  public BookGenrePub (string Name, double Cena, string Author, string Genre, string Pub) : base(Name, Cena, Author, Genre)  {
  this.Pub = Pub;
  }

  public new void Print() {
    base.Print();
    Console.WriteLine(this.Pub);
    
  }
}


class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    Book a1 = new Book("aaa", 20, "bbb");
    a1.Print();
    BookGenre a2 = new BookGenre("vvv", 30, "ddd", "bvbv");
    a2.Print();
    BookGenrePub a3 =  new BookGenrePub("vvv", 30, "ddd", "bvbv", "bcvbcvbcv");
    a3.Print();
    
  }
}
