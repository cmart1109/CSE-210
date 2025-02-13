public class SimpleGoal : Goal
{
    private bool _IsComplete;

    public SimpleGoal(string name, string description, int points) : base (name, description, points)
    {
        
    }
    public override void RecordEvent()
    {

    }
    public override bool IsComplete()
    {
        return true;
    }
    public override string GetStringRepresentation()
    {
        return "";
    }
}