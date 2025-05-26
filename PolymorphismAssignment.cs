using System;

namespace InterfaceExample
{
    // Define an interface called IQuittable
    interface IQuittable
    {
        // Method that classes implementing this interface must define
        void Quit();
    }

    // Abstract base class called Person
    abstract class Person
    {
        // Property for first name
        public string FirstName { get; set; }

        // Property for last name
        public string LastName { get; set; }

        // Abstract method that must be implemented in derived classes
        public abstract void SayName();
    }

    // Employee class inherits from Person and implements IQuittable interface
    class Employee : Person, IQuittable
    {
        // Implementation of the SayName method from the Person class
        public override void SayName()
        {
            // Prints full name to the console
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        // Implementation of the Quit method from the IQuittable interface
        public void Quit()
        {
            // Custom message when employee quits
            Console.WriteLine(FirstName + " " + LastName + " has quit the job.");
        }
    }

    // Main program class
    class Program
    {
        // Entry point of the application
        static void Main(string[] args)
        {
            // Create an Employee object and set its name
            Employee emp = new Employee();
            emp.FirstName = "Sample";
            emp.LastName = "Student";

            // Call the SayName method
            emp.SayName();

            // Use polymorphism: create an object of type IQuittable
            IQuittable quittableEmp = emp;

            // Call the Quit method on the IQuittable object
            quittableEmp.Quit();

            // Keep console window open until user presses a key
            Console.ReadLine();
        }
    }
}
