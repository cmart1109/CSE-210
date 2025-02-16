public class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public virtual int RecordEvent()
    {
    return 0;
    }
    public virtual string IsComplete()
    {
        return "";
    }
    public virtual string GetDetailsString()
    {
        return $"[{IsComplete()}] {_shortName} ({_description})";
    }
    public virtual string GetStringRepresentation()
    {
        return $"";
    }
}