using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        int guess;
        int guessCount = 0;
        String response;
        
        do{

        Random randomMagicNumber = new Random();
        int magicNumber = randomMagicNumber.Next(1,100);

        
        

        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            guessCount++;

            if (guess == magicNumber)
            {
                Console.WriteLine("Congratulations! You guessed it!");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }

        } while (guess != magicNumber);
        
        Console.WriteLine($"Tentatives {guessCount}");

        Console.Write("Do you want to play again?: ");
        response = Console.ReadLine();
        }while (response == "yes");
    }
}
