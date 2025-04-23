using System;

namespace BooleanLogicAssignment 
class Program
{
    static void Main()
    {
        // Ask the user for age
        Console.Write("What is your age? ");
        int age = Convert.ToInt32(Console.ReadLine());

        // Ask about DUI
        Console.Write("Have you ever had a DUI? (yes or no) ");
        string duiInput = Console.ReadLine().ToLower();
        bool hasDui = duiInput == "yes";

        // Ask about speeding tickets
        Console.Write("How many speeding tickets do you have? ");
        int speedingTickets = Convert.ToInt32(Console.ReadLine());

        // Check qualification rules
        bool isEligible = age > 15 && !hasDui && speedingTickets <= 3;

        // Print result
        Console.WriteLine(isEligible);
    }
}
