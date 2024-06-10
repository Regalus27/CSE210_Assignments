using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int maxNumber = 10;
        int randomNumber = randomGenerator.Next(1, maxNumber + 1);
        int guess = 0;
        Console.WriteLine($"Guess a number between 1 and {maxNumber}.");
        while (guess != randomNumber)
        {
            if (int.TryParse(Console.ReadLine(), out guess))
            {
                if (guess > randomNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Higher");
                }
            }
            else
            {
                Console.WriteLine($"Invalid Input. Please enter a number between 1 and {maxNumber}.");
            }
        }
        Console.WriteLine("You Guessed it!");
    }
}