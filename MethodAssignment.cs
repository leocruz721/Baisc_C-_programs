// MathOperations.cs
public class MathOperations
{
    // Method that accepts two integers, with the second one being optional (defaults to 0)
    public int PerformOperation(int number1, int number2 = 0)
    {
        // Adds the two numbers and returns the result
        return number1 + number2;
    }
}
// Program.cs
using System;

class Program
{
    static void Main()
    {
        // Create an instance of the MathOperations class
        MathOperations mathOps = new MathOperations();

        // Ask the user for the first number
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine()); // Read and convert the first number

        // Ask the user for the second number, but inform them it's optional
        Console.Write("Enter the second number (optional, press Enter to skip): ");
        string input2 = Console.ReadLine(); // Read the second number as a string

        // If the user entered a second number, convert it; otherwise, use 0
        int num2 = 0;
        if (!string.IsNullOrEmpty(input2))
        {
            num2 = int.Parse(input2); // Convert to integer if the user provided a value
        }

        // Call the method with both numbers and display the result
        int result = mathOps.PerformOperation(num1, num2); // Pass in both numbers
        Console.WriteLine("The result is: " + result);

        // You could try different combinations of inputs (one or two numbers)
    }
}
