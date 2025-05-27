using System;

namespace ConstructorChainingExample
{
    // Define a class named 'Person'
    class Person
    {
        public string Name;
        public int Age;

        // Constructor that takes only the name
        public Person(string name) : this(name, 0) // Chaining to another constructor
        {
            // This constructor passes the name and a default age (0) to the next constructor
        }

        // Constructor that takes both name and age
        public Person(string name, int age)
        {
            Name = name; // Set the name
            Age = age;   // Set the age
        }

        // Method to display person's info
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a constant variable. Its value cannot be changed.
            const string greeting = "Welcome to the Person App!";
            Console.WriteLine(greeting); // Output the greeting to the console

            // Create a variable using 'var' keyword. The type is inferred as 'int'.
            var year = 2025;
            Console.WriteLine($"Current year is: {year}");

            // Create an instance of Person using constructor chaining
            Person person1 = new Person("Alice");

            // Create another person using the full constructor
            Person person2 = new Person("Bob", 30);

            // Display information about both persons
            person1.DisplayInfo();
            person2.DisplayInfo();

            // Keep the console window open
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
