using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.WriteLine("What is your name?: ");
            string name = Console.ReadLine();
            return name; 
        }
        static int PromptUserNumber()
        {
            Console.WriteLine("What is your favorite Number?: ");
            string userNumber = Console.ReadLine();
            int number = int.Parse(userNumber);
            return number;
        }
        static int SquareNumber(int numberSelected)
        {
            int squarednumber = numberSelected * numberSelected;
            return squarednumber;
        }
        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"Brother {name}, the square of your number is {square}");
        }

        DisplayWelcome();
        string name = PromptUserName(); 
        int userNumber = PromptUserNumber();
        int SquaredNumber = SquareNumber(userNumber);
        DisplayResult(name, SquaredNumber);

    }
}