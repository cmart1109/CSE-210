public class Assignment 
{
    protected string _studentname;
    private string _topic;

    public Assignment(string name, string topic)
    {
        _studentname = name;
        _topic = topic;
    }
    public string GetSummary()
    {
        return $"{_studentname} - {_topic}";
    }
}