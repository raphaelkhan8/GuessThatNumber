using System;

// Namespace: namespace is a container for classes and functions
namespace GuessThatNumber
{
    // Main Class
    class Program
    {
        // Entry point for application
        static void Main(string[] args)
        {

            GetAppInfo();

            GreetUser();

            while (true) 
            {
                // Initial correct number
                // int correctNumber = 7;

                // Create a new Random object
                Random random = new Random();

                // make the correctNumber a random number between 1 and 10
                int correctNumber = random.Next(1, 11);

                // Initial guess variable
                int guess = 0;

                // Ask user to guess the number
                Console.WriteLine("Guess a number between 1 and 10");

                // While user's guess is incorrect
                while (guess != correctNumber) 
                {
                    // Get user's input
                    string input = Console.ReadLine();
                    // If the input is not a number
                    if (!int.TryParse(input, out guess)) 
                    {
                        // Print non-integer error message
                        PrintColorMessage(ConsoleColor.DarkRed, "Please enter an actual number", 0);
                        // Keep going
                        continue;
                    }

                    // Parse the string input, convert it to an int and reassign the guess variable to it
                    guess = Int32.Parse(input);

                    // Compare guess with correctNumber
                    if (guess != correctNumber)
                    {
                        // Print incorrect output message
                        PrintColorMessage(ConsoleColor.Red, "{0} is incorrect. Guess again", guess);
                    }
                }
                // Print success message
                PrintColorMessage(ConsoleColor.Yellow, "Congrats! {0} was the correct number", correctNumber);

                // Ask user if they want to play again?
                Console.WriteLine("Want to play again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y") {
                    continue;
                } 
                else {
                    return;
                }
            }
        }

        // Function to get and display app info
        static void GetAppInfo()
        {
            // Set app variables
            string appName = "Guess That Number";
            string appVersion = "1.0.0";
            string appAuthor = "Raphael Khan";

            // Chamge text color to green
            Console.ForegroundColor = ConsoleColor.Green;
            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            // Reset text color to white
            Console.ResetColor();
        }

        // Function to ask for user's name and greet them
        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name");
            // Get user input
            string inputName = Console.ReadLine();
            // Greeting message
            Console.WriteLine("Hello {0}, let's play a game...", inputName.ToUpper());
        }

        // Function to print different colored messages 
        static void PrintColorMessage(ConsoleColor color, string message, int number)
        {
            // Chamge text color
            Console.ForegroundColor = color;
            // Write the message
            Console.WriteLine(message, number);
            // Reset text color to white
            Console.ResetColor();
        }
    }
}

