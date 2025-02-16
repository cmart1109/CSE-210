public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }
    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations, you've earned {_points} points!");
        return _points;
    }
    public override string IsComplete()
    {
        return "";
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
    
}