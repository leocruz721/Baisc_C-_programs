using System;
using System.Collections.Generic;

namespace GenericEmployeeExample
{
    // Define a generic Employee class with type parameter T
    class Employee<T>
    {
        // Property for a list of generic type T
        public List<T> Things { get; set; }
    }

    // Main program class
    class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee object with string as the type
            Employee<string> empStrings = new Employee<string>();
            
            // Assign a list of strings to the Things property
            empStrings.Things = new List<string>() { "Notebook", "Pen", "Laptop" };

            // Create another Employee object with int as the type
            Employee<int> empInts = new Employee<int>();
            
            // Assign a list of integers to the Things property
            empInts.Things = new List<int>() { 101, 202, 303 };

            // Loop through the string list and print each item
            Console.WriteLine("Employee<string> Things:");
            foreach (string item in empStrings.Things)
            {
                Console.WriteLine(item);
            }

            // Line break for clarity
            Console.WriteLine();

            // Loop through the int list and print each item
            Console.WriteLine("Employee<int> Things:");
            foreach (int item in empInts.Things)
            {
                Console.WriteLine(item);
            }

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
