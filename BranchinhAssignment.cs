using System;

class Program
{
    static void Main()
    {
        // Welcome message to the user
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt the user for the package weight and capture input
        Console.Write("Please enter the package weight: ");
        double weight = Convert.ToDouble(Console.ReadLine());  // Converts the input to a double

        // Check if the weight is greater than 50
        if (weight > 50)
        {
            // If the package is too heavy, show an error message and end the program
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;  // End the program
        }

        // Prompt the user for the package width and capture input
        Console.Write("Please enter the package width: ");
        double width = Convert.ToDouble(Console.ReadLine());

        // Prompt the user for the package height and capture input
        Console.Write("Please enter the package height: ");
        double height = Convert.ToDouble(Console.ReadLine());

        // Prompt the user for the package length and capture input
        Console.Write("Please enter the package length: ");
        double length = Convert.ToDouble(Console.ReadLine());

        // Check if the total dimensions (width + height + length) are greater than 50
        if (width + height + length > 50)
        {
            // If the package is too large, show an error message and end the program
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;  // End the program
        }

        // Calculate the shipping quote based on the formula
        double quote = (width * height * length * weight) / 100;

        // Display the shipping quote to the user with 2 decimal places
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");

        // Thank the user at the end of the process
        Console.WriteLine("Thank you!");

        // Wait for the user to press Enter before closing the console window
        Console.ReadLine(); // This keeps the console open so the user can see the result
    }
}
