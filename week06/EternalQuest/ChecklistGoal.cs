public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _amountCompleted += 1;
        Console.WriteLine($"Congratulations, you've earned {_points} points!");
        if (_amountCompleted == _target)
        {
        Console.WriteLine("Double Congratulations! you've achieved the number of times for a bonus!");
        Console.WriteLine($"You also earned {_bonus} points");
        return _points + _bonus;
        }
        else {
        return _points;
        }
    }
    public override string IsComplete()
    {
            {
        if (_amountCompleted == _target)
        {
        return "X";
        }
        else {
            return " ";
        }
    }
    }
    public override string GetDetailsString()
    {
        return $"[ ] {_shortName} ({_description}) -- Currently Completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}