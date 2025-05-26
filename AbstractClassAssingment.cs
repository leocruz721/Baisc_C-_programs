using System;

namespace AbstractPersonExample
{
    // Abstract class Person - cannot be instantiated directly
    abstract class Person
    {
        // Property to store the person's first name
        public string FirstName { get; set; }

        // Property to store the person's last name
        public string LastName { get; set; }

        // Abstract method that must be implemented in any derived class
        public abstract void SayName();
    }

    // Employee class inherits from the abstract Person class
    class Employee : Person
    {
        // Implementation of the SayName method defined in the abstract class
        public override void SayName()
        {
            // Prints the full name to the console in a specific format
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }

    // Main program class
    class Program
    {
        // Entry point of the application
        static void Main(string[] args)
        {
            // Creating a new Employee object and initializing properties
            Employee emp = new Employee();
            emp.FirstName = "Sample";
            emp.LastName = "Student";

            // Calling the SayName method on the Employee object
            emp.SayName();

            // Keeps the console window open until a key is pressed
            Console.ReadLine();
        }
    }
}
