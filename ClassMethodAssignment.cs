// MathOperations.cs
public static class MathOperations
{
    // Method that divides the passed number by 2 and outputs the result.
    // This method has no return value, but it performs a division operation on the integer.
    public static void DivideByTwo(int number)
    {
        // Divide the passed number by 2
        int result = number / 2;

        // Output the result of the division to the console
        Console.WriteLine("The result of dividing " + number + " by 2 is: " + result);
    }

    // Method that takes an integer as input and outputs two values via output parameters.
    // It outputs the result of division and the original number.
    public static void DivideByTwoWithOutput(int number, out int result, out int originalNumber)
    {
        // Set the original number
        originalNumber = number;

        // Divide the number by 2 and store the result
        result = number / 2;

        // Display the result of the division and the original number
        Console.WriteLine("Original number: " + originalNumber + ", Divided by 2: " + result);
    }

    // Overloaded method that accepts a double, divides it by 2, and outputs the result.
    public static void DivideByTwo(double number)
    {
        // Divide the double number by 2
        double result = number / 2;

        // Output the result of the division to the console
        Console.WriteLine("The result of dividing " + number + " by 2 is: " + result);
    }
}
// Program.cs
using System;

class Program
{
    static void Main()
    {
        // Ask the user to enter a number
        Console.Write("Enter a number to divide by 2: ");
        string input = Console.ReadLine();
        
        // Try to parse the input as an integer
        if (int.TryParse(input, out int userInput))
        {
            // Call the method to divide the integer by 2
            MathOperations.DivideByTwo(userInput);

            // Call the method with output parameters to divide and show both the original and result
            int result;
            MathOperations.DivideByTwoWithOutput(userInput, out result, out int originalNumber);
        }
        else
        {
            Console.WriteLine("Please enter a valid integer.");
        }

        // Ask the user to enter a decimal number
        Console.Write("Enter a decimal number to divide by 2: ");
        string inputDouble = Console.ReadLine();
        
        // Try to parse the input as a double
        if (double.TryParse(inputDouble, out double userInputDouble))
        {
            // Call the overloaded method for division of double type
            MathOperations.DivideByTwo(userInputDouble);
        }
        else
        {
            Console.WriteLine("Please enter a valid decimal number.");
        }
    }
}

