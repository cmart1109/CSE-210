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
    }
    public void DisplayEndingMessage()
    {
        
    }
    public void ShowSpinner(int seconds)
    {
        Console.WriteLine("Get Ready!");
        Console.Write("^");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write(">");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("v");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("<");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("^");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write(">");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("v");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("<");
        Thread.Sleep(500);
    }
    public void ShowCount(int seconds)
    {
        _duration = seconds;
    }
}