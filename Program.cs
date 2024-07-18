using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Guessing Game!");
        Console.WriteLine("Try to guess the secret number.");

        int secretNumber = 42;

        Console.Write("Enter your guess: ");
        string userInput = Console.ReadLine();
        int userGuess = Convert.ToInt32(userInput);



        if (userGuess == secretNumber)
        {
            Console.WriteLine("Congratulations! You guessed the secret number!");
        }
        else
        {
            Console.WriteLine($"Sorry, the secret number was {secretNumber}. Better luck next time!");
        }
    }
}
