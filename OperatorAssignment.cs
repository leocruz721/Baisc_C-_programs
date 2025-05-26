using System;

namespace OperatorOverloadExample
{
    // Employee class definition
    class Employee
    {
        // Property for Employee ID
        public int Id { get; set; }

        // Property for First Name
        public string FirstName { get; set; }

        // Property for Last Name
        public string LastName { get; set; }

        // Overload the == operator to compare Employee objects by their Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both are null, or both are same instance, return true
            if (ReferenceEquals(emp1, emp2))
                return true;

            // If one is null, but not both, return false
            if ((object)emp1 == null || (object)emp2 == null)
                return false;

            // Compare IDs to determine equality
            return emp1.Id == emp2.Id;
        }

        // Overload the != operator, must be done in pairs with ==
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Return the opposite of the == operator
            return !(emp1 == emp2);
        }

        // Override Equals method for completeness (optional but recommended)
        public override bool Equals(object obj)
        {
            // Try to cast the object to an Employee
            var other = obj as Employee;

            if (other == null) return false;

            return this.Id == other.Id;
        }

        // Override GetHashCode when overriding Equals (good practice)
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }

    // Main program class
    class Program
    {
        static void Main(string[] args)
        {
            // Create first Employee object and assign values
            Employee emp1 = new Employee();
            emp1.Id = 101;
            emp1.FirstName = "John";
            emp1.LastName = "Doe";

            // Create second Employee object and assign values
            Employee emp2 = new Employee();
            emp2.Id = 101;
            emp2.FirstName = "Jane";
            emp2.LastName = "Smith";

            // Compare the two Employee objects using the overloaded == operator
            if (emp1 == emp2)
            {
                Console.WriteLine("Employees are equal (same ID).");
            }
            else
            {
                Console.WriteLine("Employees are NOT equal (different ID).");
            }

            // Keep console open so you can see the result
            Console.ReadLine();
        }
    }
}
