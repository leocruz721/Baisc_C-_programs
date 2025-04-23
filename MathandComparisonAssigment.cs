using System;

class Program
{
    static void Main()
    {
        // Print the program's title
        Console.WriteLine("Anonymous Income Comparison Program");

        // Step 1: Get details for Person 1
        Console.WriteLine("Person 1");
        
        // Ask for Person 1's hourly rate
        Console.Write("Enter Person 1's hourly rate: ");
        string input1 = Console.ReadLine();  // Get the input from the user
        double hourlyRate1 = Convert.ToDouble(input1);  // Convert the input to a double
        
        // Ask for Person 1's hours worked per week
        Console.Write("Enter Person 1's hours worked per week: ");
        string input2 = Console.ReadLine();  // Get the input from the user
        double hoursWorked1 = Convert.ToDouble(input2);  // Convert the input to a double

        // Step 2: Get details for Person 2
        Console.WriteLine("Person 2");

        // Ask for Person 2's hourly rate
        Console.Write("Enter Person 2's hourly rate: ");
        string input3 = Console.ReadLine();  // Get the input from the user
        double hourlyRate2 = Convert.ToDouble(input3);  // Convert the input to a double

        // Ask for Person 2's hours worked per week
        Console.Write("Enter Person 2's hours worked per week: ");
        string input4 = Console.ReadLine();  // Get the input from the user
        double hoursWorked2 = Convert.ToDouble(input4);  // Convert the input to a double

        // Step 3: Calculate the annual salary for both persons
        double annualSalary1 = hourlyRate1 * hoursWorked1 * 52;  // Multiply hourly rate by hours worked per week and 52 weeks in a year
        double annualSalary2 = hourlyRate2 * hoursWorked2 * 52;  // Same calculation for Person 2

        // Step 4: Print the annual salaries
        Console.WriteLine("\nAnnual salary of Person 1: " + annualSalary1);  // Display annual salary for Person 1
        Console.WriteLine("Annual salary of Person 2: " + annualSalary2);  // Display annual salary for Person 2

        // Step 5: Compare the salaries and display the result
        bool makesMoreMoney = annualSalary1 > annualSalary2;  // Compare the annual salaries
        Console.WriteLine("Person 1 makes more money than Person 2: " + makesMoreMoney);  // Print the result of the comparison (true/false)
    }
}
