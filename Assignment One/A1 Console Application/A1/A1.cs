class A1
{
    //Function to calculate amount
    static void CalculateAmount(int amount, int payment)
    {
        //Check so we take valid payment & amount
        if (amount < 0 || payment < 0)
        {
            Console.WriteLine("Invalid amount or payment");
        }
        else if (payment < amount)
        {
            Console.WriteLine("Payment is less than the total price.");
        }
        else
        {
            int change = payment - amount;
            // call the calculatechange function
            CalculateChangeAmount(change);
        }
    }

    static void CalculateChangeAmount(int amount)
    {
        //efine a dictionary to map each denomination value int to its string
        var denominations = new Dictionary<int, string>
        {
            { 500, "femhundralapp" },
            { 200, "tvåhundralapp" },
            { 100, "etthundralapp" },
            { 50, "femtiolapp" },
            { 20, "tjugolapp" },
            { 10, "tiokronor" },
            { 5, "femkronor" },
            { 1, "enkronor" }
        };

        //Create a list to store the change details
        List<string> changeList = new List<string>();

        // Loop through each denomination in descending order
        foreach (int key in denominations.Keys)
        {
            //Calculate how many of the current denomination can be given from the amount
            int count = amount / key;
            
            // If the denomination count is greater than 0 it means its part of the change
            if (count > 0)
            {
                //Update the remaining amount
                amount %= key;
                
                //Add the formatted denomination count and name to the change list
                changeList.Add($"{count} {denominations[key]}");
            }
        }

        //Convert the list to an array and pass it to the PrintChange method
        string[] array = changeList.ToArray();
        PrintChange(array);
    }

    //Function to print 
    static void PrintChange(string[] array)
    { 
        //Iterate trough the array and print each item
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
    //Function that starts our pogram and propt user to enter payment and amount
    static void StartProgram()
    {
        Console.WriteLine("Ange pris: ");
        string amountString = Console.ReadLine();
        Console.WriteLine("Betalt: ");
        string paymentString = Console.ReadLine();
        //Check that we input numbers
        if (int.TryParse(amountString, out int amount) && int.TryParse(paymentString, out int payment))
        {
            CalculateAmount(amount, payment);
        }
        else
        {
            Console.WriteLine("OBS! Du måste ange belopp i siffror!");
        }
    }
    static void Main(string[] args)
    {
        StartProgram();
    }
}