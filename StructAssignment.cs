using System;

namespace StructExample
{
    // Define a struct named Number
    struct Number
    {
        // Property Amount of type decimal to hold a numeric value
        public decimal Amount { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Number struct
            Number myNumber = new Number();

            // Assign a decimal value to the Amount property
            myNumber.Amount = 1234.56m;

            // Print the value of Amount to the console
            Console.WriteLine("The amount is: " + myNumber.Amount);

            // Keep the console window open until a key is pressed
            Console.ReadLine();
        }
    }
}
