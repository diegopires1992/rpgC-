using System;
using projeto.src.Entities;
class Program
{
  static void Main(string[] args)
  {
    Knight arus = new Knight("Diego", 100, "Knight", 1000, 500);
    Wizard jenica = new Wizard("Jennica", 23, "White Wizard", 20, 50);
    BackWizard Topapa = new BackWizard("Topapa", 50, "Black Wizard", 20, 50);
    Ninja Wedge = new Ninja("Wedge", 50, "Ninja", 20, 50);



    Console.WriteLine(arus);
    Console.WriteLine(jenica);
    Console.WriteLine(Topapa);
    Console.WriteLine(Wedge);
    Console.WriteLine(arus.Attack());
    Console.WriteLine(jenica.Attack(20));
  }
}