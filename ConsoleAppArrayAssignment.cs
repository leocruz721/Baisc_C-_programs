using System;
using System.Collections.Generic; // Required for using List<T>

namespace ArrayAndListIndexSelector
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a one-dimensional array of strings
            string[] stringArray = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

            // Ask the user to select an index of the string array
            Console.WriteLine("Select an index (0 to 4) to see a fruit from the string array:");
            int stringIndex = GetValidIndexFromUser(stringArray.Length); // Get valid index

            // Display the string at the selected index
            Console.WriteLine($"You selected: {stringArray[stringIndex]}\n");

            // Create a one-dimensional array of integers
            int[] intArray = { 10, 20, 30, 40, 50 };

            // Ask the user to select an index of the integer array
            Console.WriteLine("Select an index (0 to 4) to see a number from the integer array:");
            int intIndex = GetValidIndexFromUser(intArray.Length); // Get valid index

            // Display the integer at the selected index
            Console.WriteLine($"You selected: {intArray[intIndex]}\n");

            // Create a list of strings
            List<string> stringList = new List<string> { "Red", "Green", "Blue", "Yellow", "Purple" };

            // Ask the user to select an index of the list
            Console.WriteLine("Select an index (0 to 4) to see a color from the list:");
            int listIndex = GetValidIndexFromUser(stringList.Count); // Get valid index

            // Display the string at the selected index in the list
            Console.WriteLine($"You selected: {stringList[listIndex]}\n");

            // Pause the program before closing
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        /// <summary>
        /// Prompts the user to enter a valid index and returns it.
        /// If the user enters an invalid index (e.g., out of bounds or not a number),
        /// it displays an error and prompts again.
        /// </summary>
        /// <param name="maxLength">Length of the array or list (used for bounds checking)</param>
        /// <returns>A valid integer index within bounds</returns>
        static int GetValidIndexFromUser(int maxLength)
        {
            while (true)
            {
                Console.Write("Enter an index: ");
                string input = Console.ReadLine();

                // Try to parse the user's input into an integer
                if (int.TryParse(input, out int index))
                {
                    // Check if the index is within the valid range
                    if (index >= 0 && index < maxLength)
                    {
                        return index; // Return the valid index
                    }
                    else
                    {
                        Console.WriteLine($"Invalid index. Please enter a number between 0 and {maxLength - 1}.");
                    }
                }
                else
                {
                    Console.WriteLine("That is not a valid number. Please try again.");
                }
            }
        }
    }
}
