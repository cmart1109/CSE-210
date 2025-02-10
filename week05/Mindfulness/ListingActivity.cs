
public class ListingActivity : Activity
{
    private int _count;
    List<string> _prompts = new List<string>();
    Random random = new Random();

    public ListingActivity(string name, string description) : base (name, description)
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
        
    }
    public void Run()
    {
        
        DisplayStartingMessage();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine(GetRandomPrompt());
        Thread.Sleep(1500);
        Console.WriteLine("You may begin in:");
        ShowCount(5);
        Console.WriteLine("Go!");
        DateTime startTime = DateTime.Now;
        DateTime finalTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < finalTime)
        {
        Console.ReadLine();
        _count += 1;
        }
        Console.WriteLine($"You wrote {_count} answers, well done!");
        Thread.Sleep(1000);
        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
     int selection = random.Next(1, _prompts.Count);   
     return $"{_prompts[selection]}";
    }
    public List<string> GetListFromUser()
    {
        return _prompts;
    }
}