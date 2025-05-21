using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // assignment part 1
        // Step 1: Create a one-dimensional array of strings
        string[] messages = { "Hello", "Welcome", "Goodbye", "Thanks", "See you" };

        // Step 2: Ask the user to input some text
        Console.Write("Enter some text to append to each message: ");
        string userInput = Console.ReadLine();

        // Step 3: Append the user's text to each string
        for (int i = 0; i < messages.Length; i++)
        {
            messages[i] += userInput;
        }

        // Step 4: Print each string
        Console.WriteLine("\nUpdated messages:");
        foreach (string message in messages)
        {
            Console.WriteLine(message);
        }

        // assignment part 2
        while (true)
        {
            Console.Write("\nEnter more text to append (or type 'exit' to quit): ");
            string moreInput = Console.ReadLine();

            // ✅ Break out of infinite loop when user types "exit"
            if (moreInput.ToLower() == "exit")
            {
                break;
            }

            for (int i = 0; i < messages.Length; i++)
            {
                messages[i] += moreInput;
            }

            Console.WriteLine("\nUpdated messages:");
            foreach (string message in messages)
            {
                Console.WriteLine(message);
            }
        }

        // assignment part 3
        Console.WriteLine("\nassignment part 3");

        // Loop using '<' operator
        Console.WriteLine("\nLoop using '<' operator:");
        for (int i = 0; i < messages.Length - 1; i++)
        {
            Console.WriteLine($"Index {i}: {messages[i]}");
        }

        // Loop using '<=' operator
        Console.WriteLine("\nLoop using '<=' operator:");
        for (int i = 0; i <= messages.Length - 1; i++)
        {
            Console.WriteLine($"Index {i}: {messages[i]}");
        }

        // assignment part 4
        Console.WriteLine("\nassignment part 4");

        // Step 1: Create a list of unique strings
        List<string> uniqueItems = new List<string> { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

        // Step 2: Ask user for input to search
        Console.Write("\nEnter text to search for in the list: ");
        string searchText = Console.ReadLine();

        // Step 3: Search the list
        bool matchFound = false;

        for (int i = 0; i < uniqueItems.Count; i++)
        {
            if (uniqueItems[i].Equals(searchText, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"\nMatch found at index {i}: {uniqueItems[i]}");
                matchFound = true;
                break; // ✅ Stops loop after first match
            }
        }

        // Step 4: Handle case where no match is found
        if (!matchFound)
        {
            Console.WriteLine("\nThat item is not on the list.");
        }

        Console.WriteLine("\nProgram ended.");
    }
}
