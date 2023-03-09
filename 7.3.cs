using System;

class Vehicle
{
    public string Type;
    public int NumTires;
    public int Year;
    public bool Runs;


    public Vehicle(string type, int numTires, int year,  bool runs) {
      this.Type = type;
      this.NumTires = numTires;
      this.Year = year;
      this.Runs = runs;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Vehicle car = new Vehicle(type: "car", numTires: 4, year: 2000, runs: true);
        Vehicle oldcar = new Vehicle(type: "car", numTires: 4, year: 1980, runs: false);
        Vehicle bike = new Vehicle(type: "bike", numTires: 2, year: 2017, runs: true);

        Console.WriteLine($"{car.Type}");
        Console.WriteLine($"{car.Runs}");
        Console.WriteLine($"{car.NumTires}");
      

    }
}
