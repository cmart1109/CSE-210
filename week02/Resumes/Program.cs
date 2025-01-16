using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Senior Developer";
        job1._experienceYears = 5;
        job1._language = "C++";
        job1.ShowRequirements();

        Job job2 = new Job();
        job2._jobTitle = "IT Engineer";
        job2._experienceYears = 2;
        job2._language = "Java";
        job2.ShowRequirements();
    }
}