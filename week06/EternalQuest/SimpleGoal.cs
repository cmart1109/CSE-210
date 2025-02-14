public class SimpleGoal : Goal
{
    private bool _IsComplete = false;

    public SimpleGoal(string name, string description, int points) : base (name, description, points)
    {
        
    }
    public override void RecordEvent()
    {

    }
    public override bool IsComplete()
    {
        _IsComplete = true;
        return _IsComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal,{_shortName},{_description},{_points},{_IsComplete}";
    }
}