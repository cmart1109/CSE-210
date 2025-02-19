using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activities = new List<Activity>();
            _activities.Add(new RunningActivity("18 Mar 2025",30,5.0));
            _activities.Add(new CyclingActivity("20 Mar 2025",20,9.0));
            _activities.Add(new SwimmingActivity("22 Mar 2025",40,8));
        foreach (Activity activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
    }


