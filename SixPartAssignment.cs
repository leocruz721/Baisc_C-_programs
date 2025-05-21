using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // assignment part 1
        // Create an array of strings
        string[] messages = { "Hello", "Welcome", "Goodbye", "Thanks", "See you" };

        // Ask user to input some text
        Console.Write("Enter some text to append to each message: ");
        string userInput = Console.ReadLine();

        // Append user input to each string in the array
        for (int i = 0; i < messages.Length; i++)
        {
            messages[i] += userInput;
        }

        // Print the updated strings
        Console.WriteLine("\nUpdated messages:");
        foreach (string message in messages)
        {
            Console.WriteLine(message);
        }

        // assignment part 2
        // Start an infinite loop to continuously accept new text
        while (true)
        {
            Console.Write("\nEnter more text to append (or type 'exit' to quit): ");
            string moreInput = Console.ReadLine();

            // Exit the loop if user types 'exit'
            if (moreInput.ToLower() == "exit")
            {
                break; // ✅ Fixed the infinite loop by adding a break condition
            }

            // Append the new text to each message
            for (int i = 0; i < messages.Length; i++)
            {
                messages[i] += moreInput;
            }

            // Print updated messages
            Console.WriteLine("\nUpdated messages:");
            foreach (string message in messages)
            {
                Console.WriteLine(message);
            }
        }

        // assignment part 3
        Console.WriteLine("\nassignment part 3");

        // Use < operator to loop through all but the last item
        Console.WriteLine("\nLoop using '<' operator:");
        for (int i = 0; i < messages.Length - 1; i++)
        {
            Console.WriteLine($"Index {i}: {messages[i]}");
        }

        // Use <= operator to include the last item
        Console.WriteLine("\nLoop using '<=' operator:");
        for (int i = 0; i <= messages.Length - 1; i++)
        {
            Console.WriteLine($"Index {i}: {messages[i]}");
        }

        // assignment part 4
        Console.WriteLine("\nassignment part 4");

        // Create a list with unique strings
        List<string> uniqueItems = new List<string> { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

        // Ask user to search for an item
        Console.Write("\nEnter text to search for in the list: ");
        string searchText = Console.ReadLine();

        bool matchFound = false;

        // Search for a match and stop at first match
        for (int i = 0; i < uniqueItems.Count; i++)
        {
            if (uniqueItems[i].Equals(searchText, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"\nMatch found at index {i}: {uniqueItems[i]}");
                matchFound = true;
                break; // ✅ Stops after first match
            }
        }

        // If no match was found
        if (!matchFound)
        {
            Console.WriteLine("\nThat item is not on the list.");
        }

        // assignment part 5
        Console.WriteLine("\nassignment part 5");

        // List with duplicate values
        List<string> duplicateItems = new List<string> { "Dog", "Cat", "Bird", "Dog", "Fish", "Cat" };

        // Ask user for text to search for
        Console.Write("\nEnter text to search for in the list (with duplicates): ");
        string searchInput = Console.ReadLine();

        bool found = false;

        // Loop to find all matching indices
        for (int i = 0; i < duplicateItems.Count; i++)
        {
            if (duplicateItems[i].Equals(searchInput, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Match found at index {i}: {duplicateItems[i]}");
                found = true;
            }
        }

        // If no match was found
        if (!found)
        {
            Console.WriteLine("\nThat item is not on the list.");
        }

        // assignment part 6
        Console.WriteLine("\nassignment part 6");

        // List with duplicates
        List<string> checkDuplicates = new List<string> { "A", "B", "C", "D", "C" };

        // Create a HashSet to track items we've already seen
        HashSet<string> seenItems = new HashSet<string>();

        // Loop through each item in the list
        foreach (string item in checkDuplicates)
        {
            // If the item hasn't been seen before
            if (!seenItems.Contains(item))
            {
                Console.WriteLine($"{item} - this item is unique");
                seenItems.Add(item); // Add it to the set
            }
            else
            {
                // If already seen, it's a duplicate
                Console.WriteLine($"{item} - this item is a duplicate");
            }
        }

        Console.WriteLine("\nProgram ended.");
    }
}
