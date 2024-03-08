using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> primeMinisters = new Dictionary<int, string>()
        {
            { 1998, "Atal Bihari Vajpayee" },
            { 2014, "Narendra Modi" },
            { 2004, "Manmohan Singh" }
        };

        // Find the Prime Minister of 2004
        int yearToFind = 2004;
        if (primeMinisters.ContainsKey(yearToFind))
        {
            string primeMinister2004 = primeMinisters[yearToFind];
            Console.WriteLine($"Prime Minister of {yearToFind}: {primeMinister2004}");
        }
        else
        {
            Console.WriteLine($"No Prime Minister found for the year {yearToFind}");
        }

        // Add the current Prime Minister
        int currentYear = 2024;
        string currentPrimeMinister = "Narendra Modi";
        primeMinisters[currentYear] = currentPrimeMinister;
        Console.WriteLine($"\nAdded the current Prime Minister ({currentPrimeMinister})");

        // Sort the dictionary by year
        var sortedPrimeMinisters = primeMinisters.OrderBy(p => p.Key);
        Console.WriteLine("\nSorted Prime Ministers:");
        foreach (var kvp in sortedPrimeMinisters)
        {
            Console.WriteLine($"{kvp.Value}, {kvp.Key}");
        }
    }
}
