// Program.cs
using System;

class Program
{
    public static void Main(string[] args)
    {
        string filePath = "sellers.json";
        
        
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Lägg till säljare");
            Console.WriteLine("2. Visa alla säljare");
            Console.WriteLine("0. Lämnna programmet");
            Console.Write("Välj ett alternativ: ");

            string input = Console.ReadLine();
            if (input == "0")
            {
                Console.WriteLine("Lämmnar programmet!");
                break; // Exit the loop and close the program
            }
            else if (input == "1")
            {
                SellerController.AddSellerToFile(); // Call the method to add a seller
            }
            else if (input == "2")
            {
                SellerController.PrintSellers(filePath); // Call the method to print sellers
            }
            else
            {
                Console.WriteLine("Inte tillåtet, försk igen!.");
            }
            Console.WriteLine(); 
        }
    
    }
}

