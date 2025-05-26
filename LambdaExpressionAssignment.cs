using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeListExample
{
    // Define the Employee class with Id, FirstName, and LastName properties
    class Employee
    {
        public int Id { get; set; }          // Employee ID
        public string FirstName { get; set; } // Employee first name
        public string LastName { get; set; }  // Employee last name
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of 10 employees with at least two named "Joe"
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id = 1, FirstName = "Joe", LastName = "Smith" },
                new Employee() { Id = 2, FirstName = "Jane", LastName = "Doe" },
                new Employee() { Id = 3, FirstName = "Joe", LastName = "Johnson" },
                new Employee() { Id = 4, FirstName = "Mary", LastName = "Brown" },
                new Employee() { Id = 5, FirstName = "James", LastName = "Wilson" },
                new Employee() { Id = 6, FirstName = "Patricia", LastName = "Taylor" },
                new Employee() { Id = 7, FirstName = "Robert", LastName = "Anderson" },
                new Employee() { Id = 8, FirstName = "Linda", LastName = "Thomas" },
                new Employee() { Id = 9, FirstName = "Michael", LastName = "Jackson" },
                new Employee() { Id = 10, FirstName = "Barbara", LastName = "White" }
            };

            // Use a foreach loop to create a list of employees whose first name is "Joe"
            List<Employee> joesUsingLoop = new List<Employee>(); // List to hold "Joe" employees

            // Loop through each employee in the employees list
            foreach (Employee emp in employees)
            {
                // Check if the employee's first name is "Joe"
                if (emp.FirstName == "Joe")
                {
                    // Add the matching employee to the joesUsingLoop list
                    joesUsingLoop.Add(emp);
                }
            }

            // Print the employees named Joe found by the foreach loop
            Console.WriteLine("Employees named Joe (using foreach loop):");
            foreach (Employee joe in joesUsingLoop)
            {
                Console.WriteLine($"Id: {joe.Id}, Name: {joe.FirstName} {joe.LastName}");
            }
            Console.WriteLine();

            // Use a lambda expression to find all employees named "Joe"
            List<Employee> joesUsingLambda = employees.Where(emp => emp.FirstName == "Joe").ToList();

            // Print the employees named Joe found by the lambda expression
            Console.WriteLine("Employees named Joe (using lambda expression):");
            foreach (Employee joe in joesUsingLambda)
            {
                Console.WriteLine($"Id: {joe.Id}, Name: {joe.FirstName} {joe.LastName}");
            }
            Console.WriteLine();

            // Use a lambda expression to find employees with Id greater than 5
            List<Employee> idGreaterThanFive = employees.Where(emp => emp.Id > 5).ToList();

            // Print employees whose Id is greater than 5
            Console.WriteLine("Employees with Id greater than 5:");
            foreach (Employee emp in idGreaterThanFive)
            {
                Console.WriteLine($"Id: {emp.Id}, Name: {emp.FirstName} {emp.LastName}");
            }

            // Keep the console window open until a key is pressed
            Console.ReadLine();
        }
    }
}
