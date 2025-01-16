public class Resume()
{
    public string _name;
    public List<Job> _jobs = new List<Job>();
    public void DisplayResume()
    {
        Console.WriteLine($"{_name}");
        Console.WriteLine($"Job Experience: ");
        foreach (var Job in _jobs)
        {
            Job.ShowRequirements();
        }
    }
}