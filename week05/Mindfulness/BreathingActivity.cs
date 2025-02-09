using System.Data;
using System.Reflection.PortableExecutable;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base (name, description)
    {

    }
    public void Run()
    {
        DisplayStartingMessage();
        while (_duration > 0) 
        {
        Console.WriteLine($"Breathe in...");
        ShowCount(5);
        Console.WriteLine($"Okay, now Breathe out...");
        ShowCount(5);

        }
        DisplayEndingMessage();
        }
    }
