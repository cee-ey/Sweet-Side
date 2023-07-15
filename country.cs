using System;
using System.Collections.Generic;

public class Continent
{
    public string Name { get; set; }
    public List<string> Countries { get; set; }

    public Continent(string name, List<string> countries)
    {
        Name = name;
        Countries = countries;
    }
}

private class Program
{
    public static void Main(string[] args)
    {
        Continent asia = new Continent("Asia", new List<string> { "China", "Thailand", "Philippines" });
        Continent america = new Continent("America", new List<string> { "U.S.A.", "Canada", "Argentina" });
        Continent europe = new Continent("Europe", new List<string> { "Italy", "France", "Greece" });

        Console.WriteLine("Asia:");
        foreach (string country in asia.Countries)
        {
            Console.WriteLine("- " + country);
        }

        Console.WriteLine("\nAmerica:");
        foreach (string country in america.Countries)
        {
            Console.WriteLine("- " + country);
        }

        Console.WriteLine("\nEurope:");
        foreach (string country in europe.Countries)
        {
            Console.WriteLine("- " + country);
        }
    }
}
