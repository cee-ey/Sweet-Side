using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Creating continents
        Continent asia = new Continent("Asia");
        Continent america = new Continent("America");
        Continent europe = new Continent("Europe");

        // Creating countries in Asia
        Country china = new Country("China");
        china.Foods.Add("Peanut Butter Bun");
        china.Foods.Add("Curry Beef Triangle");
        china.Foods.Add("Nuomici");

        Country thailand = new Country("Thailand");
        thailand.Foods.Add("Mango Sticky Rice");
        thailand.Foods.Add("Pa Thong Ko");
        thailand.Foods.Add("Bua Loi");

        Country philippines = new Country("Philippines");
        philippines.Foods.Add("Hopia (Monggo)");
        philippines.Foods.Add("Buko Pie");
        philippines.Foods.Add("Ensaymada");

        asia.Countries.Add(china);
        asia.Countries.Add(thailand);
        asia.Countries.Add(philippines);

        // Creating countries in America
        Country usa = new Country("USA");
        usa.Foods.Add("Almond Bear Claw");
        usa.Foods.Add("Cronut");
        usa.Foods.Add("Malasadas");

        Country canada = new Country("Canada");
        canada.Foods.Add("Beaver Tails");
        canada.Foods.Add("Timbits");
        canada.Foods.Add("Blueberry Grunt");

        Country argentina = new Country("Argentina");
        argentina.Foods.Add("Medialunas");
        argentina.Foods.Add("Empanadas Tucumanas");
        argentina.Foods.Add("Pastelitos Criollos");

        america.Countries.Add(usa);
        america.Countries.Add(canada);
        america.Countries.Add(argentina);

        // Creating countries in Europe
        Country italy = new Country("Italy");
        italy.Foods.Add("Genovesi");
        italy.Foods.Add("Seada");
        italy.Foods.Add("Struffoli");

        Country france = new Country("France");
        france.Foods.Add("Dariole");
        france.Foods.Add("Rissole");
        france.Foods.Add("Flan Pâtissier");

        Country greece = new Country("Greece");
        greece.Foods.Add("Kalitsounia");
        greece.Foods.Add("Diples");
        greece.Foods.Add("Loukoumades");

        europe.Countries.Add(italy);
        europe.Countries.Add(france);
        europe.Countries.Add(greece);

        // Displaying the data
        Console.WriteLine("Continents:");
        Console.WriteLine("-----------");

        Console.WriteLine("Asia:");
        foreach (var country in asia.Countries)
        {
            Console.WriteLine($"- {country.Name}");
            Console.WriteLine("  Foods:");
            foreach (var food in country.Foods)
            {
                Console.WriteLine($"  - {food}");
            }
        }

        Console.WriteLine("\nAmerica:");
        foreach (var country in america.Countries)
        {
            Console.WriteLine($"- {country.Name}");
            Console.WriteLine("  Foods:");
            foreach (var food in country.Foods)
            {
                Console.WriteLine($"  - {food}");
            }
        }

        Console.WriteLine("\nEurope:");
        foreach (var country in europe.Countries)
        {
            Console.WriteLine($"- {country.Name}");
            Console.WriteLine("  Foods:");
            foreach (var food in country.Foods)
            {
                Console.WriteLine($"  - {food}");
            }
        }
    }
}