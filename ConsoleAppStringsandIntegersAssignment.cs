using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of integers
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

        // Ask the user for a number to divide each number by
        Console.Write("Enter a number to divide each number in the list by: ");
        
        // Declare a variable to store the user's input
        string userInput = Console.ReadLine();
        
        // Declare a variable for the divisor, initially set to 0
        int divisor = 0;

        // Try parsing the user input to an integer
        bool isValidInput = int.TryParse(userInput, out divisor);

        // Use a try/catch block to handle potential errors during division
        try
        {
            // Check if the input is a valid integer
            if (!isValidInput)
            {
                throw new FormatException("The input is not a valid number.");
            }

            // Check if the divisor is zero
            if (divisor == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }

            // Loop through the list and divide each number by the divisor
            Console.WriteLine("\nResults:");
            foreach (int num in numbers)
            {
                int result = num / divisor; // Perform the division
                Console.WriteLine($"{num} / {divisor} = {result}"); // Display the result
            }
        }
        // Catch specific exceptions and display relevant error messages
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"\nError: {ex.Message}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"\nError: {ex.Message}");
        }
        catch (Exception ex) // Catch any other general exceptions
        {
            Console.WriteLine($"\nUnexpected error: {ex.Message}");
        }
        // Finally, display a message to show that the program continues after the try/catch block
        finally
        {
            Console.WriteLine("\nProgram execution has continued after the try/catch block.");
        }
    }
}
