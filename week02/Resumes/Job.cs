using System;

public class Job
{
    public string _jobTitle;
    public int _experienceYears;
    public string _language;

    public Job()
    {
    }

    public void ShowRequirements()
    {
        Console.WriteLine("These are the details");
        Console.WriteLine($"{_jobTitle}: you need {_experienceYears} years of experience in {_language},");
    }
    


}