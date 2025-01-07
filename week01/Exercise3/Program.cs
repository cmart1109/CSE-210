using System;
using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int numbers = random.Next(1,10);
        int guesser;
        do 
        {
        Console.WriteLine("What is your Guess?: ");
        string guess = Console.ReadLine();
        guesser = int.Parse(guess);
        if (numbers == guesser)
        {
            Console.WriteLine("You Guessed it!");
            Console.WriteLine("Play Again?: ");
            string decision = Console.ReadLine();
            if (decision == "yes")
            {
                guesser = 0;
            }
            else 
            {
                
            }
        }
        else if (guesser > numbers)
        {
            Console.WriteLine("lower");
        }
        else
        {
            Console.WriteLine("Higher");
        }

        } while (guesser != numbers);

        }

    }
