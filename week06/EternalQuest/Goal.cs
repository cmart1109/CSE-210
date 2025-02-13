public class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public virtual void RecordEvent()
    {

    }
    public virtual bool IsComplete()
    {
        return false;
    }
    public virtual string GetDetailsString()
    {
        return $"[ ] {_shortName} ({_description})";
    }
    public virtual string GetStringRepresentation()
    {
        return "Representation";
    }
}