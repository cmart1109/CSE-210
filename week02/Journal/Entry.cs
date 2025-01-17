public class Entry
{
    DateTime TheCurrentTime;
    string _date;
    string _promptText;
    string _entryText;
    public void GetEntry() 
    {
        TheCurrentTime = DateTime.Now;
        _date = TheCurrentTime.ToShortDateString();
        PromptGenerator prompt = new PromptGenerator();
        _promptText = prompt.GetRandomPrompt();
        _entryText = Console.ReadLine();
    }
    public void Display()
    {
        Console.WriteLine($"{_date}, Prompt: {_promptText}");
        Console.WriteLine(_entryText);
        
    }
    public override string ToString()
    {
        return $"{_date}, Prompt: {_promptText}\n{_entryText}";
    }
}