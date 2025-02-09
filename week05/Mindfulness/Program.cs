using System;

class Program
{
    
    static void Main(string[] args)
    {
        string election;
        do 
        {
        Console.WriteLine("Menu Options");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine("Select a Choice from de menu: ");
        election = Console.ReadLine();
        if (election == "1")
        {
            BreathingActivity breathing = new BreathingActivity("Breathing", "This Activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");
            breathing.Run();
        }
        else if (election == "2")
        {
            ReflectingActivty reflecting = new ReflectingActivty("Reflecting", "This Activity will help you reflecto on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life");
            reflecting.Run();
        }
        else if (election == "3")
        {
            ListingActivity listing = new ListingActivity("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            listing.Run();
        }
        } while (election != "4");
    }
}