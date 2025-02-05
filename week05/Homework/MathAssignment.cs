public class MathAssignment : Assignment
{
    private string _textbooksession;
    private string _problems;

    public MathAssignment (string name, string topic, string bookSession, string problem) : base(name, topic)
    {
        
       _problems = problem;
       _textbooksession = bookSession;
    }
    public string GetHomeworkString()
    {
        return $"Section {_textbooksession}, Problems {_problems}";
    } 
}