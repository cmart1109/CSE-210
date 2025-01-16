using System;

public class Job
{   
    public string _companyName;
    public string _jobTitle;
    public string _time;
    public string _language;

    public Job()
    {
    }

    public void ShowRequirements()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_time}, {_language},");
    }
    


}