using System; // Import the System namespace for basic functionality like Console

namespace BooleanLoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a variable to track the number of iterations
            int count = 0;

            // ---------------- WHILE LOOP EXAMPLE ----------------
            // This loop continues to execute as long as 'count < 5' is true
            while (count < 5)
            {
                // Print the current value of count
                Console.WriteLine("While Loop - Count is: " + count);

                // Increment the count to eventually break the loop
                count++;
            }

            // Reset the counter before the next loop
            count = 0;

            // ---------------- DO-WHILE LOOP EXAMPLE ----------------
            // The do-while loop will always execute at least once,
            // and continue as long as 'count < 3' is true
            do
            {
                // Print the current value of count
                Console.WriteLine("Do-While Loop - Count is: " + count);

                // Increment the count
                count++;
            }
            while (count < 3); // Boolean condition checked after each loop iteration

            // Wait for user input before closing the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
