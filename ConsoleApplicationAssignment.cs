using System;

class Program
{
    static void Main()
    {
        // Step 1: Take input from the user, multiply it by 50, and print the result
        Console.Write("Enter a number to multiply by 50: ");
        string input1 = Console.ReadLine(); // Get user input as string
        double num1 = Convert.ToDouble(input1); // Convert the input to a double to handle large numbers
        double result1 = num1 * 50; // Multiply the number by 50
        Console.WriteLine("Result of multiplication by 50: " + result1); // Print the result

        // Step 2: Take input from the user, add 25 to it, and print the result
        Console.Write("Enter a number to add 25: ");
        string input2 = Console.ReadLine(); // Get user input as string
        double num2 = Convert.ToDouble(input2); // Convert the input to a double
        double result2 = num2 + 25; // Add 25 to the number
        Console.WriteLine("Result of adding 25: " + result2); // Print the result

        // Step 3: Take input from the user, divide it by 12.5, and print the result
        Console.Write("Enter a number to divide by 12.5: ");
        string input3 = Console.ReadLine(); // Get user input as string
        double num3 = Convert.ToDouble(input3); // Convert the input to a double
        double result3 = num3 / 12.5; // Divide the number by 12.5
        Console.WriteLine("Result of division by 12.5: " + result3); // Print the result

        // Step 4: Take input from the user, check if it is greater than 50, and print true/false
        Console.Write("Enter a number to check if it is greater than 50: ");
        string input4 = Console.ReadLine(); // Get user input as string
        double num4 = Convert.ToDouble(input4); // Convert the input to a double
        bool isGreaterThan50 = num4 > 50; // Check if the number is greater than 50
        Console.WriteLine("Is the number greater than 50? " + isGreaterThan50); // Print the result (true/false)

        // Step 5: Take input from the user, divide it by 7, and print the remainder (using the modulus operator %)
        Console.Write("Enter a number to divide by 7 and get the remainder: ");
        string input5 = Console.ReadLine(); // Get user input as string
        double num5 = Convert.ToDouble(input5); // Convert the input to a double
        double remainder = num5 % 7; // Get the remainder when dividing by 7
        Console.WriteLine("Remainder when divided by 7: " + remainder); // Print the remainder
    }
}
