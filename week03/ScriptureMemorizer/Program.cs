using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        string index;
        Reference reference = new Reference("Proverbs",3,5,6);
        Scripture scripture = new Scripture(reference, "¶ Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him and he shall direct thy paths");
        scripture.GetDisplayText();
        do 
        {
        Console.WriteLine("Press Enter to Continue or type 'quit' to Finish");
        index = Console.ReadLine();
        if (index == "quit")
        {

        }
        else {
            scripture.HideRandomWords(random.Next(1/5));
        }
        } while (index != "quit");

    }
}