using System;

class Program
{
    static void Main()
    {
        using (var context = new AppDbContext())
        {
            // Ensure database is created
            context.Database.EnsureCreated();

            // Create and add a student
            var student = new Student
            {
                FirstName = "John",
                LastName = "Doe"
            };

            context.Students.Add(student);
            context.SaveChanges();

            Console.WriteLine("Student added successfully!");
        }
    }
}
