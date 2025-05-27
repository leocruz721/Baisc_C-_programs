using System;

namespace AgeToBirthYearApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display an initial message to the user
            Console.WriteLine("Please enter your age:");

            try
            {
                // Read the user's input from the console
                string input = Console.ReadLine();

                // Attempt to convert the input string to an integer
                int age = Convert.ToInt32(input);

                // Check if the age is less than or equal to zero
                if (age <= 0)
                {
                    // Display a specific message if the user enters zero or a negative number
                    Console.WriteLine("Error: Age must be a positive number greater than zero.");
                }
                else
                {
                    // Calculate the birth year by subtracting age from the current year
                    int currentYear = DateTime.Now.Year;
                    int birthYear = currentYear - age;

                    // Display the birth year to the user
                    Console.WriteLine($"You were born in approximately {birthYear}.");
                }
            }
            catch (FormatException)
            {
                // This block handles input that can't be converted to an integer (e.g., letters or symbols)
                Console.WriteLine("Error: Please enter a valid number for your age.");
            }
            catch (Exception ex)
            {
                // This block catches all other exceptions and displays a general message
                Console.WriteLine("An unexpected error occurred. Please try again.");
                // Optionally: Log or show the actual error message for debugging
                // Console.WriteLine($"Technical details: {ex.Message}");
            }

            // Pause the program before it closes
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
