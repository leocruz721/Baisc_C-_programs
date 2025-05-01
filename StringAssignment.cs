using System;             // Import the System namespace for basic input/output functionality
using System.Text;        // Import the Text namespace for using StringBuilder

namespace StringManipulationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------
            // 1. Concatenate three strings
            // -----------------------------------
            string firstName = "John";                   // First name
            string middleName = "Fitzgerald";            // Middle name
            string lastName = "Kennedy";                 // Last name

            // Concatenate the three strings with spaces in between
            string fullName = firstName + " " + middleName + " " + lastName;

            // Display the concatenated full name
            Console.WriteLine("Full Name: " + fullName);


            // -----------------------------------
            // 2. Convert a string to uppercase
            // -----------------------------------
            string lowerCaseMessage = "this text will be uppercased.";

            // Convert the string to all uppercase letters
            string upperCaseMessage = lowerCaseMessage.ToUpper();

            // Display the uppercase string
            Console.WriteLine("Uppercase Message: " + upperCaseMessage);


            // -----------------------------------
            // 3. Use StringBuilder to build a paragraph
            // -----------------------------------

            // Create a new StringBuilder instance
            StringBuilder paragraphBuilder = new StringBuilder();

            // Append sentences to the paragraph
            paragraphBuilder.Append("This is the first sentence. "); // Sentence 1
            paragraphBuilder.Append("Here is another sentence that continues the thought. "); // Sentence 2
            paragraphBuilder.Append("Finally, this is the concluding sentence of the paragraph."); // Sentence 3

            // Convert the StringBuilder to a string and display the paragraph
            Console.WriteLine("Paragraph:");
            Console.WriteLine(paragraphBuilder.ToString());

            // Keep the console window open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey(); // Waits for the user to press a key
        }
    }
}
