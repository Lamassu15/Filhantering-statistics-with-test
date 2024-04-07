using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        // Testa metoden med en string-array
        string[] inputArray = { "apple", "banana", "orange", "avocado", "grape", "Qota", "Batbot" };

        foreach (var item in inputArray)
        {
            Console.WriteLine(item);
        }

        // Loopa över bokstäverna A-Z
        for (char letter = 'a'; letter <= 'z'; letter++)
        {
            List<string> filteredList = FilterElementsStartingWith(inputArray, letter);

            // Anropa metoden för att skapa katalog och spara filen för varje bokstav
            SaveListToFile(filteredList, letter);
        }
    }

    static List<string> FilterElementsStartingWith(string[] inputArray, char startingLetter)
    {
        // Skapa en generisk lista för att lagra resultaten
        List<string> resultList = new List<string>();

        // Loopa igenom varje element i arrayen och filtrera de som börjar på specificerad bokstav
        foreach (var item in inputArray)
        {
            if (item.StartsWith(startingLetter.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                resultList.Add(item);
            }
        }

        // Returnera den resulterande listan
        return resultList;
    }

    static void SaveListToFile(List<string> filteredList, char startingLetter)
    {
        // Skapa en katalog baserat på den givna bokstaven
        string directoryPath = $"{startingLetter.ToString().ToUpper()}_Directory";
        Directory.CreateDirectory(directoryPath);

        // Skapa filens sökväg
        string filePath = Path.Combine(directoryPath, $"{startingLetter}_List.txt");

        // Spara listan som en textfil
        File.WriteAllLines(filePath, filteredList);
        // show file path in the console
        Console.WriteLine($"File saved to: {filePath}");
    }
}
