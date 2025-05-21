using System;

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

        // Step 3: A loop that appends the user's text to each string in the array
        for (int i = 0; i < messages.Length; i++)
        {
            messages[i] += userInput; // Append input to each element
        }

        // Step 4: A second loop that prints each updated string
        Console.WriteLine("\nUpdated messages:");
        foreach (string message in messages)
        {
            Console.WriteLine(message);
        }

        // assignment part 2
        // Step 5: Add an infinite loop (with exit condition)
        while (true)
        {
            Console.Write("\nEnter more text to append (or type 'exit' to quit): ");
            string moreInput = Console.ReadLine();

            // ✅ Fix the infinite loop: Exit if user types "exit"
            if (moreInput.ToLower() == "exit")
            {
                break;
            }

            // Append new input to each message in the array
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

        // Loop using the "<" operator
        Console.WriteLine("\nLoop using '<' operator:");
        for (int i = 0; i < messages.Length - 1; i++) // "<" means stops at second to last index
        {
            Console.WriteLine($"Index {i}: {messages[i]}");
        }

        // Loop using the "<=" operator
        Console.WriteLine("\nLoop using '<=' operator:");
        for (int i = 0; i <= messages.Length - 1; i++) // "<=" includes the last index
        {
            Console.WriteLine($"Index {i}: {messages[i]}");
        }

        Console.WriteLine("\nProgram ended.");
    }
}
