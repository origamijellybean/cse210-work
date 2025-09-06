using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        int guess = 0;
        string rawGuess = "0";
        Console.Write("Guess the magic number (1-100)!");

        do
        {
            Console.Write("What is your guess? ");
            rawGuess = Console.ReadLine();
            guess = int.Parse(rawGuess);
            if (guess == magicNumber)
                Console.WriteLine("You guessed it!");
            else if (guess > magicNumber)
                Console.WriteLine("Lower");
            else if (guess < magicNumber)
                Console.WriteLine("Higher");
        } while (guess != magicNumber);
    }

}