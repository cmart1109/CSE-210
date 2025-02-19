public class SwimmingActivity : Activity
{
    private int _numberOfLaps;
    public SwimmingActivity(string date, double length, int numberOfLaps) : base (date, length)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        return _numberOfLaps * 50 / 100;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / _length) * 60;
    }
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}