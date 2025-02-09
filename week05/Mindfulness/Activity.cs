public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
{
    _name = name;
    _description = description;
}
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity");
        Console.WriteLine("");
        Console.WriteLine($"{_description}");
        Console.WriteLine("How long, in seconds would you like for your session?:");
        string seconds = Console.ReadLine();
        _duration = int.Parse(seconds);
        Console.WriteLine("Get ready!...");
        ShowSpinner(5);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You have completed the {_name} activity");
        ShowSpinner(4);
        
    }
    public void ShowSpinner(int seconds)
    {
        int inSeconds = seconds;
        while (inSeconds > 0)
        {
        Console.Write("^");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write(">");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("v");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("<");
        Thread.Sleep(250);
        Console.Write("\b \b");
        inSeconds -= 1;
        }
    }
    public void ShowCount(int seconds)
    {
        int inCount = seconds;
        while (inCount > 0)
        {
        Console.Write($"{inCount}");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        _duration -= 1;
        inCount -= 1;
        }
    }
}