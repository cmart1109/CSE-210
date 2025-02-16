public class SimpleGoal : Goal
{
    private bool _IsComplete = false;

    public SimpleGoal(string name, string description, int points) : base (name, description, points)
    {
        
    }
    public override int RecordEvent()
    {
        _IsComplete = true;
        Console.WriteLine($"Congratulations, you've earned {_points} points!");
        return _points;
        
    }
    public override string IsComplete()
    {
        if (_IsComplete == true)
        {
        return "X";
        }
        else {
            return " ";
        }
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal,{_shortName},{_description},{_points},{_IsComplete}";
    }
}