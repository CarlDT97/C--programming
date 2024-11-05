using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

public class SellerController
{
    static Seller CreateSeller(string name, long personNumber, string district, int soldArticles, int level)
    {
        Seller seller = new Seller
        {
            Name = name,
            PersonNumber = personNumber,
            District = district,
            SoldArticles = soldArticles,
            Level = level
        };
        
        return seller;
    }

    public static void AddSellerToFile()
    {
        Console.WriteLine("Skriv in namn:");
        string name = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Namnet kan inte vara tomt");
            return;
        }

        Console.WriteLine("Skriv in person nummer:");
        string personNumberInput = Console.ReadLine();
        if (!long.TryParse(personNumberInput, out long personNumber) || !IsValidPersonnummer(personNumberInput))
        {
            Console.WriteLine("Inte giltilgt pnr");
            return;
        } 
        

        Console.WriteLine("Skriv in distrikt:");
        string district = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(district))
        {
            Console.WriteLine("Distrikt kan inte vara tomt.");
            return;
        }

        Console.WriteLine("Antal sålda artiklar:");
        string soldArticlesInput = Console.ReadLine();
        if (!int.TryParse(soldArticlesInput, out int soldArticles))
        {
            Console.WriteLine("Ej giltilgt");
            return;
        }

        // Set level based on sold articles
        int level = SetLevel(soldArticles);

        // Create the new seller
        Seller newSeller = CreateSeller(name, personNumber, district, soldArticles, level);

        // Serialize the new seller to JSON
        string jsonString = JsonSerializer.Serialize(newSeller, new JsonSerializerOptions { WriteIndented = true });

        // Define the file path where the JSON will be saved
        string filePath = "sellers.json";

        // Append the new seller to the JSON file
        AppendToJsonFile(filePath, jsonString);

        Console.WriteLine($"Seller data saved to {filePath}");
    }

 public static bool IsValidPersonnummer(string personnummer)
    {
        // Ensure the input is a 10-digit number
        if (personnummer.Length != 10 || !long.TryParse(personnummer, out _))
        {
            return false;
        }

        int sum = 0;

        // Loop through each digit in the personnummer
        for (int i = 0; i < personnummer.Length; i++)
        {
            int digit = int.Parse(personnummer[i].ToString());

            // Multiply every second digit by 2, starting from the right
            if ((personnummer.Length - 1 - i) % 2 == 1)
            {
                digit *= 2;

                // If the result is greater than 9, add the digits of the result
                if (digit > 9)
                {
                    sum += (digit % 10) + 1; // Add the digits together
                }
                else
                {
                    sum += digit;
                }
            }
            else
            {
                sum += digit; // Add the digit directly
            }
        }

        // Check if the sum is divisible by 10
        return sum % 10 == 0;
    }
    // Method to append JSON to a file
    static void AppendToJsonFile(string filePath, string jsonString)
    {
        // Check if the file exists
        if (!File.Exists(filePath))
        {
            // If the file does not exist, create it and write the JSON string as an array
            File.WriteAllText(filePath, "[" + jsonString + "]");
        }
        else
        {
            // If the file exists, append the new seller
            string existingJson = File.ReadAllText(filePath);
            existingJson = existingJson.TrimEnd(']') + "," + jsonString + "]";
            File.WriteAllText(filePath, existingJson);
        }
    }

    static int SetLevel(int itemSold)
    {
        if (itemSold < 50)
        {
            return 1; // Level 1 for under 50 articles
        }
        else if (itemSold >= 50 && itemSold <= 99)
        {
            return 2; // Level 2 for 50-99 articles
        }
        else if (itemSold >= 100 && itemSold <= 199)
        {
            return 3; // Level 3 for 100-199 articles
        }
        else
        {
            return 4; // Level 4 for over 199 articles
        }
    }

    public static List<Seller> GetSellersFromFile(string filePath)
    {
        // Check if the file exists
        if (!File.Exists(filePath))
        {
            Console.WriteLine($"File not found: {filePath}");
            return new List<Seller>(); // Return an empty list if the file doesn't exist
        }

        // Read the JSON data from the file
        string jsonString = File.ReadAllText(filePath);
        
        // Deserialize the JSON data into a List<Seller>
        List<Seller> sellers = JsonSerializer.Deserialize<List<Seller>>(jsonString);
        
        return sellers ?? new List<Seller>(); // Return an empty list if deserialization fails
    }

public static void PrintSellers(string filePath)
{
    List<Seller> sellers = GetSellersFromFile(filePath);
    if (sellers.Count == 0)
    {
        Console.WriteLine("Inga säljare registrerade!");
        return;
    }

    // Group sellers by their level
    var groupedSellers = sellers.GroupBy(s => s.Level);
    Console.WriteLine("Säljare sorterade efter grupp");
    Console.WriteLine("#---------------------------#"); // Add a space between groups

    // Print sellers grouped by levels with counts
    foreach (var group in groupedSellers)
    {
        int numberOfSellersInLevel = group.Count(); // Count sellers in the group
        Console.WriteLine("| Namn | PersonNummer | Distrikt | Antal |");
        foreach (var seller in group)
        {
        Console.WriteLine($"| {seller.Name} | {seller.PersonNumber} | {seller.District} | {seller.SoldArticles} |");
        }
        Console.WriteLine($"{numberOfSellersInLevel} säljare har nått nivå {group.Key}.");
        Console.WriteLine("#---------------------------#"); // Add a space between groups
    }
}

}
