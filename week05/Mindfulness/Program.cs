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
            breathing.DisplayStartingMessage();
            Console.WriteLine("How long, in seconds would you like for your session?:");
            string duration = Console.ReadLine();
            int durationInt = int.Parse(duration);
            breathing.ShowSpinner(10);
            breathing.ShowCount(durationInt);
            breathing.Run();
            
            
            
        }
        } while (election != "4");
    }
}