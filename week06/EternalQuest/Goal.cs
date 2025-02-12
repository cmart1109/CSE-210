public class Goal
{
    private string _shortName;
    private string _description;
    private string _points;

    public Goal(string name, string description, string points)
    {

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
        return "Algun dia sabremos";
    }
    public virtual string GetStringRepresentation()
    {
        return "Representation";
    }
}