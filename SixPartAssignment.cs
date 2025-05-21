using System;

class Program
{
    static void Main()
    {
        //Assingment Part 1
        // Step 1: Create a one-dimensional array of strings
        string[] messages = { "Hello", "Welcome", "Goodbye", "Thanks", "See you" };

        // Step 2: Ask the user to input some text
        Console.Write("Enter some text to append to each message: ");
        string userInput = Console.ReadLine();

        // Step 3: Append the user's input to each string in the array
        for (int i = 0; i < messages.Length; i++)
        {
            messages[i] += userInput; // Append input to each element
        }

        // Step 4: Print each updated string in the array
        Console.WriteLine("\nUpdated messages:");
        foreach (string message in messages)
        {
            Console.WriteLine(message);
        }
    }
}
