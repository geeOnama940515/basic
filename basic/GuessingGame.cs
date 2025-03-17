/*

C# Guessing Game
This program implements a simple number guessing game in C#.
The program generates a random number between 1 and 10, and the user has to guess the number.   
After each guess, the program provides feedback on whether the guess is too high or too low.
Once the user guesses the correct number, the program displays the number of attempts made.

*/

namespace basic; // Namespace declaration.

public class GuessingGame // Define a class called GuessingGame.
{
    // Constructor: Runs automatically when an object of this class is created.
    public GuessingGame()
    {
        Console.WriteLine("Welcome to the Guessing Game!"); // Display welcome message.
        PlayGame(); // Call the PlayGame method to start the game.
    }

    // Method to handle the guessing game logic.
    private void PlayGame()
    {
        Random random = new Random(); // Create a Random object to generate random numbers.
        int secretNumber = random.Next(1, 11); // Generate a random number between 1 and 10.
        int attempts = 0; // Variable to count the number of attempts.
        bool isCorrect = false; // Boolean to track if the user guessed correctly.

        Console.WriteLine("I have chosen a number between 1 and 10. Try to guess it!");

        // Loop runs until the user guesses the correct number.
        while (!isCorrect)
        {
            Console.Write("Enter your guess: "); // Prompt the user for input.
            string input = Console.ReadLine(); // Read user input as a string.

            // Try to convert the input into an integer.
            if (int.TryParse(input, out int guess))
            {
                attempts++; // Increment attempt count.

                // Check if the guessed number is too low.
                if (guess < secretNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                // Check if the guessed number is too high.
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                // If the guessed number is correct.
                else
                {
                    Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts.");
                    isCorrect = true; // Set isCorrect to true to exit the loop.
                }
            }
            else
            {
                // If input is not a number, display an error message.
                Console.WriteLine("Invalid input. Please enter a number between 1 and 10.");
            }
        }
    }
}
