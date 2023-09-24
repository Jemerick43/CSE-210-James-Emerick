using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Boolean running = true; //JE
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 10);
        Console.WriteLine("Random Number Generated\n");

        int numberOfGuesses = 0;

        while (running)
        {
            Console.WriteLine("What is your guess? ");
            int guess = int.Parse(Console.ReadLine()); //JE
            numberOfGuesses++;

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher ");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it! It took you {0} guesses!", numberOfGuesses);
            }

            Console.WriteLine("Would you like to play again? (Y/N)");
            string keepPlaying = Console.ReadLine(); //JE

            if (keepPlaying == "y" || keepPlaying == "Y")
            {
                running = true; //JE
            }
            else
            {
                running = false; //JE
            }

        }
    }
}