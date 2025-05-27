using System;

namespace AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter their age
            Console.Write("Enter your age: ");

            try
            {
                // Read input from console
                string userInput = Console.ReadLine();

                // Try to convert the input to an integer
                int age = Convert.ToInt32(userInput);

                // Check if age is zero or negative
                if (age <= 0)
                {
                    Console.WriteLine("Oops... Age can't be zero or negative. Please enter a valid age.");
                }
                else
                {
                    // Calculate the birth year
                    int currentYear = DateTime.Now.Year;
                    int birthYear = currentYear - age;

                    // Output the result
                    Console.WriteLine($"Looks like you were born around {birthYear}.");
                }
            }
            catch (FormatException)
            {
                // If user enters something that isn't a number
                Console.WriteLine("That doesn't look like a number. Please enter your age using digits.");
            }
            catch (Exception)
            {
                // Catch anything else unexpected
                Console.WriteLine("Something went wrong. Please try again.");
            }

            // Keep the console window open until the user presses a key
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
