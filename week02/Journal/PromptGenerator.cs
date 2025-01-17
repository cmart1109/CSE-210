using System.CodeDom.Compiler;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    
        public string GetRandomPrompt()
    {
        _prompts.Add("Who was the most interesting person i interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How Did i see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion i felt today?");
        _prompts.Add("If i had one thing i could do over today, what whould it be?");   
        Random random = new Random();
        int randomPrompt = random.Next(1, _prompts.Count);
        Console.WriteLine(_prompts[randomPrompt]);
        return _prompts[randomPrompt];
        
    }
    
}