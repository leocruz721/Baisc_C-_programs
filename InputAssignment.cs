using System;
using System.IO;  // Needed for file operations

namespace NumberLoggerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter a number
            Console.WriteLine("Please enter a number:");

            // Read user input from the console as a string
            string userInput = Console.ReadLine();

            // Define the path of the text file where the number will be saved
            string filePath = "numberLog.txt";

            try
            {
                // Write the user's input to the text file (overwrites if file exists)
                File.WriteAllText(filePath, userInput);

                // Read the content of the text file back into a string variable
                string fileContent = File.ReadAllText(filePath);

                // Print the content of the file to the console
                Console.WriteLine("\nThe content of the file is:");
                Console.WriteLine(fileContent);
            }
            catch (Exception ex)
            {
                // If any error occurs during file operations, print an error message
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            // Wait for the user to press a key before closing the program
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
