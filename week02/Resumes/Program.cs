using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._companyName = "Microsoft";
        job1._jobTitle = "Senior Developer";
        job1._time = "2009-2016";
        job1._language = "C++";
        job1.ShowRequirements();

        Job job2 = new Job();
        job2. _companyName = "Activision";
        job2._jobTitle = "IT Engineer";
        job2._time = "2016-2022";
        job2._language = "Java";
        job2.ShowRequirements();

        Resume resume = new Resume();
        resume._name = "Christian Martinez";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.DisplayResume();
    }
}