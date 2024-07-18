using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Guessing Game!");
        Console.WriteLine("Try to guess the secret number. (Between 1 & 100)");

        Random random = new Random();
        int secretNumber = random.Next(1, 101);
        int guessesLeft = 4;
        int guessesMade = 0;

        while (guessesLeft > 0)
        {
            guessesMade++;
            Console.Write($"Your guess ({guessesMade}): , guesses left: {guessesLeft}: ");
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

