using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int magicNumber = random.Next(1, 101); // Generate a random number from 1 to 100

        Console.WriteLine("Welcome to the Guessing Game!");

        while (true)
        {
            Console.Write("Enter your guess (1-100): ");
            int guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Too high! Try again.");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the magic number.");
                break; // Exit the loop if the guess is correct
            }
        }
    }
    
}