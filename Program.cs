using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Guessing Game!");
        Console.WriteLine("Try to guess the secret number.");

        Console.Write("Enter your guess: ");
        string userInput = Console.ReadLine();
        int userGuess = Convert.ToInt32(userInput);

        Console.WriteLine($"You guessed: {userGuess}");
    }
}
