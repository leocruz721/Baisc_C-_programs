using System;

class Program
{
    static void Main()
    {
        // Print the name of the college
        Console.WriteLine("Academy of Learning Career College");

        // Print the title of the report
        Console.WriteLine("Student Daily Report.");

        // Ask for and store the student's name
        Console.Write("What is your name? ");
        string studentName = Console.ReadLine();  // Store the input as a string

        // Ask for and store the student's course
        Console.Write("What course are you on? ");
        string courseName = Console.ReadLine();  // Store the input as a string

        // Ask for and store the current page number
        Console.Write("What page number? ");
        int pageNumber = int.Parse(Console.ReadLine());  // Parse the input as an integer

        // Ask if the student needs help, storing the response as a boolean
        Console.Write("Do you need help with anything? Please answer “true” or “false”. ");
        bool needsHelp = bool.Parse(Console.ReadLine());  // Parse the input as a boolean

        // Ask for any positive experiences and store the feedback
        Console.Write("Were there any positive experiences you’d like to share? Please give specifics. ");
        string positiveExperience = Console.ReadLine();  // Store the input as a string

        // Ask for other feedback and store the response
        Console.Write("Is there any other feedback you’d like to provide? Please be specific. ");
        string additionalFeedback = Console.ReadLine();  // Store the input as a string

        // Ask how many hours the student studied today and store as an integer
        Console.Write("How many hours did you study today? ");
        int studyHours = int.Parse(Console.ReadLine());  // Parse the input as an integer

        // Print the closing message
        Console.WriteLine("\nThank you for your answers. An Instructor will respond shortly. Have a great day!");

        // Optional: Display all collected data for confirmation (you could remove or comment this out)
        Console.WriteLine("\n--- Report Summary ---");
        Console.WriteLine($"Name: {studentName}");
        Console.WriteLine($"Course: {courseName}");
        Console.WriteLine($"Page Number: {pageNumber}");
        Console.WriteLine($"Needs Help: {needsHelp}");
        Console.WriteLine($"Positive Experiences: {positiveExperience}");
        Console.WriteLine($"Additional Feedback: {additionalFeedback}");
        Console.WriteLine($"Study Hours: {studyHours}");
    }
}
