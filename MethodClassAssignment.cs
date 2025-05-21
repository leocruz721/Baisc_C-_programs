// MathOperations.cs
public class MathOperations
{
    // Method that takes two integers as parameters
    // Performs a math operation (multiplication by 2) on the first integer
    // Displays the second integer to the screen
    public void PerformOperation(int number1, int number2)
    {
        // Perform a math operation (multiplying the first number by 2)
        int result = number1 * 2;

        // Display the result of the math operation
        Console.WriteLine("The result of multiplying the first number by 2 is: " + result);

        // Display the second number as provided
        Console.WriteLine("The second number is: " + number2);
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

        // Call the method by passing two integers directly
        // The first integer is 5, the second integer is 10
        mathOps.PerformOperation(5, 10);

        // Call the method by specifying parameters by name
        // This allows for a clearer association between the parameter names and the values
        mathOps.PerformOperation(number1: 7, number2: 14);
    }
}
