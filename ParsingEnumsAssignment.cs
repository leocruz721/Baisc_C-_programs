using System;

namespace EnumDaysExample
{
    // Define an enum representing days of the week
    enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the current day of the week
            Console.WriteLine("Please enter the current day of the week:");

            // Read user input from the console
            string userInput = Console.ReadLine();

            try
            {
                // Attempt to convert the user input string to the enum DaysOfWeek
                // Enum.Parse throws an exception if the string does not match any enum name
                DaysOfWeek currentDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput, ignoreCase: true);

                // If successful, print the day
                Console.WriteLine("You entered: " + currentDay);
            }
            catch (ArgumentException)
            {
                // This block runs if Enum.Parse fails to match the input string
                Console.WriteLine("Please enter an actual day of the week.");
            }

            // Keep console open until user presses a key
            Console.ReadLine();
        }
    }
}
