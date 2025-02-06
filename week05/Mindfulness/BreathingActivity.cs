using System.Data;
using System.Reflection.PortableExecutable;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base (name, description)
    {

    }
    public void Run()
    {
        int duration = _duration; 
        while (duration > 0) 
        {
        Console.WriteLine($"Breathe in...");
        int inBreath = 5;
        while (inBreath > 0)
        {
        Console.Write($"{inBreath}");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        duration -= 1;
        inBreath -= 1;
        }
        Console.WriteLine($"Okay, now Breathe out...");
        int outBreath = 5;
        while (outBreath > 0)
        {
        Console.Write($"{outBreath}");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        duration -= 1;
        outBreath -= 1;
        }
        }
    }
}