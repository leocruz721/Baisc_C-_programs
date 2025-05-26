using System;

namespace SimpleEmployeeApp
{
    // Base class called Person
    class Person
    {
        // Property to store the first name
        public string FirstName { get; set; }

        // Property to store the last name
        public string LastName { get; set; }

        // Method that prints the full name to the console
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }

    // Employee class that inherits from Person
    class Employee : Person
    {
        // Additional property for Employee ID
        public int Id { get; set; }
    }

    // Program class that contains the Main method (entry point)
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a new Employee object
            Employee emp = new Employee();

            // Setting the FirstName and LastName properties
            emp.FirstName = "Sample";
            emp.LastName = "Student";

            // Optionally set the Id (not required but shown here)
            emp.Id = 1;

            // Calling the SayName method from the base class
            emp.SayName();

            // Keep the console window open until user presses a key
            Console.ReadLine();
        }
    }
}
