// MathOperations.cs
public class MathOperations
{
    // Method that accepts an integer and adds 10 to it
    public int PerformOperation(int number)
    {
        return number + 10;  // Adds 10 to the provided integer and returns the result
    }

    // Overloaded method that accepts a decimal and multiplies it by 2
    public int PerformOperation(decimal number)
    {
        return (int)(number * 2);  // Multiplies the decimal number by 2, casts it to an integer, and returns the result
    }

    // Overloaded method that accepts a string, converts it to an integer, and subtracts 5
    public int PerformOperation(string numberStr)
    {
        // Try to parse the string to an integer
        if (int.TryParse(numberStr, out int number))
        {
            return number - 5;  // If successful, subtract 5 from the number and return the result
        }
        else
        {
            return 0;  // If the string cannot be parsed to an integer, return 0
        }
    }
}
// Program.cs
using System;

class Program
{
    static void Main()
    {
        // Ask the user for an integer input
        Console.Write("Enter an integer: ");
        int intInput = int.Parse(Console.ReadLine()); // Convert user input to an integer

        // Create an instance of the MathOperations class
        MathOperations mathOps = new MathOperations();

        // Call the method that accepts an integer and display the result
        int resultInt = mathOps.PerformOperation(intInput);
        Console.WriteLine("Result (Integer operation): " + resultInt);

        // Ask the user for a decimal input
        Console.Write("Enter a decimal number: ");
        decimal decimalInput = decimal.Parse(Console.ReadLine()); // Convert user input to a decimal

        // Call the overloaded method that accepts a decimal and display the result
        int resultDecimal = mathOps.PerformOperation(decimalInput);
        Console.WriteLine("Result (Decimal operation): " + resultDecimal);

        // Ask the user for a string that represents a number
        Console.Write("Enter a string representing a number: ");
        string stringInput = Console.ReadLine(); // Get string input from user

        // Call the overloaded method that accepts a string and display the result
        int resultString = mathOps.PerformOperation(stringInput);
        Console.WriteLine("Result (String operation): " + resultString);
    }
}
