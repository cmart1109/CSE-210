public class ReflectingActivty : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    Random random = new Random();

    public ReflectingActivty(string name, string description) : base (name, description)
    {
        
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Consider the Following prompt:");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        Console.WriteLine("You may begin in:");
        ShowCount(5);
        while (_duration > 0) 
        {
        DisplayQuestion();
        ShowSpinner(8);
        _duration -= 8;

        }
        DisplayEndingMessage();

    }
    public string GetRandomPrompt()
    {
        int randomPrompt = random.Next(1, _prompts.Count);
        return _prompts[randomPrompt];
        
    }
    public string GetRandomQuestion()
    {
        int randomPrompt = random.Next(1, _questions.Count);
        return _questions[randomPrompt];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"____{GetRandomPrompt()}___");
    }
    public void DisplayQuestion()
    {
        Console.WriteLine($"{GetRandomQuestion()}");
    }
}