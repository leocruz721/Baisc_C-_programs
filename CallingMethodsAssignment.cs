// MathOperations.cs
public class MathOperations
{
    // Method that adds 10 to the input number and returns the result
    public int AddTen(int number)
    {
        return number + 10;
    }

    // Method that subtracts 5 from the input number and returns the result
    public int SubtractFive(int number)
    {
        return number - 5;
    }

    // Method that multiplies the input number by 3 and returns the result
    public int MultiplyByThree(int number)
    {
        return number * 3;
    }
}
// Program.cs
using System;

class Program
{
    static void Main()
    {
        // Ask the user to enter a number to perform math operations on
        Console.Write("Enter a number: ");
        int userInput = int.Parse(Console.ReadLine()); // Parse the user's input into an integer

        // Create an instance of the MathOperations class
        MathOperations mathOps = new MathOperations();

        // Call each method and display the result on the screen

        // Call AddTen method and display the result
        int resultAdd = mathOps.AddTen(userInput);
        Console.WriteLine("Add 10: " + resultAdd);

        // Call SubtractFive method and display the result
        int resultSubtract = mathOps.SubtractFive(userInput);
        Console.WriteLine("Subtract 5: " + resultSubtract);

        // Call MultiplyByThree method and display the result
        int resultMultiply = mathOps.MultiplyByThree(userInput);
        Console.WriteLine("Multiply by 3: " + resultMultiply);
    }
}
