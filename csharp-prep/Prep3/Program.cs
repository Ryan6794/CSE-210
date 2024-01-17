using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int magicnumb = randomGenerator.Next(1, 10);
        int guess = 11;

        while (guess != magicnumb)
        {
            Console.WriteLine("Try and guess the magic number 1-10");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicnumb)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicnumb)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Congrats thats right");
            }

        }

    }
}