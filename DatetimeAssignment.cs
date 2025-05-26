using System;

namespace TimeCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the current date and time to the console
            Console.WriteLine("Current date and time: " + DateTime.Now);

            // Ask the user to enter a number of hours
            Console.WriteLine("Please enter a number (hours):");

            // Read the user's input as a string
            string input = Console.ReadLine();

            // Try to convert the user input to an integer
            bool isValidNumber = int.TryParse(input, out int hoursToAdd);

            // If the input is valid, calculate and display the future time
            if (isValidNumber)
            {
                // Add the entered number of hours to the current time
                DateTime futureTime = DateTime.Now.AddHours(hoursToAdd);

                // Print the exact future time after adding the hours
                Console.WriteLine($"The time in {hoursToAdd} hour(s) will be: {futureTime}");
            }
            else
            {
                // Inform the user that the input was invalid
                Console.WriteLine("Invalid input. Please enter a valid integer number.");
            }

            // Wait for the user to press a key before closing the program
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
