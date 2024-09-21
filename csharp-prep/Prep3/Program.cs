using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        int guessValue = -1;

        while (guessValue != magicNumber)
        {
            Console.WriteLine("What is your guess");
            guessValue = int.Parse(Console.ReadLine());

            if (guessValue < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guessValue > magicNumber)
            {
                Console.WriteLine("Lower");
            }
        }

        Console.WriteLine("it is correct!");

    }
}