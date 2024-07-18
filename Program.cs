using System;

class Program
{
    static void Main()
    {
        int secretNumber = 42;
        int guessesLeft = 4;

        while (guessesLeft > 0)
        {
            Console.Write("Guess the secret number (between 1 and 100): ");
            int userGuess = Convert.ToInt32(Console.ReadLine());

            if (userGuess == secretNumber)
            {
                Console.WriteLine("Congratulations! You guessed the secret number.");
                break;
            }
            else
            {
                guessesLeft--;
                Console.WriteLine("Incorrect guess.");

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
        }

        Console.WriteLine("Game over. Press any key to exit.");
        Console.ReadKey();
    }
}
