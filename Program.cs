using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Guessing Game!");
        Console.WriteLine("Try to guess the secret number. (Between 1 & 100)");

        Console.WriteLine("Choose a difficulty level:");
        Console.WriteLine("1. Easy (8 guesses)");
        Console.WriteLine("2. Medium (6 guesses)");
        Console.WriteLine("3. Hard (4 guesses)");

        int difficultyChoice;
        int guessesLeft = 0;

        // Input validation for difficulty choice
        while (true)
        {
            Console.Write("Enter your choice (1, 2, or 3): ");
            if (int.TryParse(Console.ReadLine(), out difficultyChoice) && (difficultyChoice >= 1 && difficultyChoice <= 3))
            {
                // Set guessesLeft based on difficultyChoice
                switch (difficultyChoice)
                {
                    case 1:
                        guessesLeft = 8;
                        break;
                    case 2:
                        guessesLeft = 6;
                        break;
                    case 3:
                        guessesLeft = 4;
                        break;
                    default:
                        break;
                }

                break; // Exit the loop if a valid choice is made
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
            }
        }

        Random random = new Random();
        int secretNumber = random.Next(1, 101);
        int guessesMade = 0;

        while (guessesLeft > 0)
        {
            guessesMade++;
            Console.Write($"Your guess ({guessesMade}), guesses left: {guessesLeft}: ");
            int userGuess;

            // Input validation for user guess
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out userGuess))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.Write($"Your guess ({guessesMade}), guesses left: {guessesLeft}: ");
                }
            }

            if (userGuess == secretNumber)
            {
                Console.WriteLine("Congratulations! You guessed the secret number.");
                break;
            }
            else if (userGuess < secretNumber)
            {
                Console.WriteLine("Incorrect guess. Too low!");
            }
            else
            {
                Console.WriteLine("Incorrect guess. Too high!");
            }

            guessesLeft--;

            if (guessesLeft > 0)
            {
                Console.WriteLine($"You have {guessesLeft} guesses left.");
            }
            else
            {
                Console.WriteLine("Sorry, you've run out of guesses.");
                Console.WriteLine($"The secret number was {secretNumber}.");
            }
        }

        Console.WriteLine("Game over. Press any key to exit.");
        Console.ReadKey();
    }
}

